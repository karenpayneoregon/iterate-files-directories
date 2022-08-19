using System.Linq;
using System.Text.RegularExpressions;

namespace FolderHelpers.LanguageExtensions
{
    /// <summary>
    /// Common string extensions 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Split string with spaces at upper chars
        /// </summary>
        /// <param name="sender">valid string</param>
        /// <returns>When string has upper case chars e.g. KarenPayne the  result is Karen Payne</returns>
        public static string SplitCamelCase(this string sender) =>
            string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
                .Select(m => m.Value));
    }
}
