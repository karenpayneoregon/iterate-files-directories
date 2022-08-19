using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FolderHelpers.Classes
{
    public class DirectoryHelpers
    {
        /// <summary>
        /// Get file count for directory and sub folders no filtering for search pattern
        /// </summary>
        /// <param name="directory">directory to get file count</param>
        /// <returns>count of files</returns>
        /// <remarks>
        /// An exception is thrown if insufficient permissions for file or folder
        /// </remarks>
        public static int FileCount(string directory)
        {
            DirectoryInfo dirInfo = new(directory);
            return dirInfo.EnumerateDirectories().AsParallel()
                .SelectMany(di => di.EnumerateFiles("*.*", SearchOption.AllDirectories)).Count();
        }

        /// <summary>
        /// Get file count for directory and sub folders no filtering for search pattern
        /// </summary>
        /// <param name="directory">directory to get file count</param>
        /// <param name="searchOption">Top level or all folders</param>
        /// <returns>count of files</returns>
        /// <remarks>
        /// An exception is thrown if insufficient permissions for file or folder
        /// </remarks>
        public static int FileCount(string directory, SearchOption searchOption)
        {
            DirectoryInfo dirInfo = new(directory);
            return dirInfo.EnumerateDirectories().AsParallel()
                .SelectMany(di => di.EnumerateFiles("*.*", searchOption)).Count();
        }

        /// <summary>
        /// Get file count for directory and sub folders no filtering for search pattern
        /// </summary>
        /// <param name="directory">directory to get file count</param>
        /// <param name="searchOption">Top level or all folders</param>
        /// <param name="searchPattern">File type e.g.  *.txt</param>
        /// <returns>count of files</returns>
        /// <remarks>
        /// An exception is thrown if insufficient permissions for file or folder
        /// </remarks>
        public static int FileCount(string directory, SearchOption searchOption, string searchPattern)
        {
            DirectoryInfo dirInfo = new(directory);
            return dirInfo.EnumerateDirectories().AsParallel()
                .SelectMany(di => di.EnumerateFiles(searchPattern, searchOption)).Count();
        }

        /// <summary>
        /// Get count of file count with exception handling which should be used if there is a chance
        /// of insufficient permissions for file or folder
        /// </summary>
        /// <param name="directory">directory to get file count</param>
        /// <param name="searchOption"></param>
        /// <param name="searchPattern"></param>
        /// <returns>count and if an exception is thrown the exception</returns>
        public static (int count, Exception exception) FileCountSafe(string directory, SearchOption searchOption, string searchPattern = "*.*")
        {
            try
            {
                DirectoryInfo dirInfo = new(directory);
                return (dirInfo.EnumerateDirectories().AsParallel().SelectMany(di => di.EnumerateFiles(searchPattern, searchOption)).Count(), null);
            }
            catch (Exception localException)
            {
                return (-1, localException);
            }
        }

        /// <summary>
        /// Get folder count and file count for top level and sub folders
        /// </summary>
        /// <param name="directory">directory to get file count</param>
        /// <returns>file and directory counts</returns>
        /// <remarks>
        /// An exception is thrown if insufficient permissions for file or folder
        /// </remarks>
        public static (int directoryCount, int fileCount) DirectoryFileCount(string directory)
        {
            Dictionary<bool, int> dictionary = new DirectoryInfo(directory)
                .EnumerateFileSystemInfos("*", SearchOption.AllDirectories)
                .GroupBy(fsi => fsi is DirectoryInfo)
                .ToDictionary(item => item.Key, s => s.Count());

            return (dictionary.ContainsKey(true) ? dictionary[true] : 0, dictionary.ContainsKey(false) ? dictionary[false] : 0);
        }

        /// <summary>
        /// Get folder count and file count for top level and sub folders
        /// </summary>
        /// <param name="directory">directory to get file count</param>
        /// <param name="searchOption">Top level or all folders</param>
        /// <returns>file and directory counts</returns>
        /// <remarks>
        /// An exception is thrown if insufficient permissions for file or folder
        /// </remarks>
        public static (int directoryCount, int fileCount) DirectoryFileCount(string directory,  SearchOption searchOption)
        {
            Dictionary<bool, int> dictionary = new DirectoryInfo(directory)
                .EnumerateFileSystemInfos("*", searchOption)
                .GroupBy(fsi => fsi is DirectoryInfo)
                .ToDictionary(item => item.Key, s => s.Count());

            return (dictionary.ContainsKey(true) ? dictionary[true] : 0, dictionary.ContainsKey(false) ? dictionary[false] : 0);
        }
    }

}