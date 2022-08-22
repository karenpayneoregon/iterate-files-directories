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

        public delegate void OnUnauthorizedAccess(string sender);

        public event OnUnauthorizedAccess OnNoAccess;

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
        /// A safe way to get all the files in a directory and sub directory without crashing on UnauthorizedException or PathTooLongException
        /// </summary>
        /// <param name="directory">Starting directory</param>
        /// <param name="searchPattern">Filename pattern match</param>
        /// <param name="searchOption">Search subdirectories or only top level directory for files</param>
        /// <returns>List of files</returns>
        public IEnumerable<string> EnumerateFilesSafe(string directory, string searchPattern, SearchOption searchOption)
        {
            var list = Enumerable.Empty<string>();

            if (searchOption == SearchOption.AllDirectories)
            {
                try
                {
                    IEnumerable<string> childDirectories = Directory.EnumerateDirectories(directory);

                    list = childDirectories.Aggregate(list, (current, dir) =>
                        current.Concat(EnumerateFilesSafe(dir, searchPattern, searchOption)));

                }
                catch (UnauthorizedAccessException unauthorized)
                {
                    OnNoAccess?.Invoke(unauthorized.Message);
                }
                catch (PathTooLongException tooLong)
                {
                    OnNoAccess?.Invoke(tooLong.Message);
                }
            }

            try
            {
                list = list.Concat(Directory.EnumerateFiles(directory, searchPattern));
            }
            catch (UnauthorizedAccessException unauthorized)
            {
                OnNoAccess?.Invoke(unauthorized.Message);
            }

            Done?.Invoke();
            return list;
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