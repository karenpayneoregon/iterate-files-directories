using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FolderHelpers.LanguageExtensions;

namespace FolderHelpers.Classes
{
    public class FileOperations
    {
        public delegate void OnTraverse(string sender);
        /// <summary>
        /// Triggered on each iteration in <seealso cref="EnumerateFiles"/>
        /// </summary>
        public event OnTraverse Traverse;

        public delegate void OnDone();
        /// <summary>
        /// Triggered upon completion of  <seealso cref="EnumerateFiles"/> work
        /// </summary>
        public event OnDone Done;

        /// <summary>
        /// Traverse a directory in search of files
        /// </summary>
        /// <param name="directory">directory to traverse</param>
        /// <param name="searchPattern">File type/wild cards</param>
        /// <param name="searchOption"><seealso cref="SearchOption"/></param>
        /// <param name="ct"><seealso cref="CancellationToken"/> for permitting cancellation</param>
        /// <returns>Task</returns>
        /// <remarks>
        /// An exception is thrown if insufficient permissions for file or folder
        /// </remarks>
        public async Task EnumerateFiles(string directory, string searchPattern, SearchOption searchOption, CancellationToken ct)
        {
            using var enumerator = await Task.Run(() => Directory.EnumerateFiles(directory, searchPattern, searchOption).GetEnumerator(), ct);
            while (await Task.Run(() => enumerator.MoveNext(), ct))
            {
                Traverse?.Invoke(enumerator.Current);
            }

            Done?.Invoke();
        }
        /// <summary>
        /// Provides DataSource to a custom ComboBox in FrontendApp project
        /// </summary>
        /// <returns></returns>
        public static List<SearchOptionItem> SearchOptions() => 
            Enum.GetValues(typeof(SearchOption)).Cast<SearchOption>()
                .Select(x => new SearchOptionItem(x.ToString()
                    .SplitCamelCase(), x)).ToList();
    }
}
