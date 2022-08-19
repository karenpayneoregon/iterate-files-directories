using System.IO;

namespace FolderHelpers.Classes
{
    /// <summary>
    /// For custom ComboBox in FrontendApp
    /// </summary>
    public class SearchOptionItem
    {
        /// <summary>
        /// Text to display
        /// </summary>
        public string Text { get; }
        /// <summary>
        /// Actual value
        /// </summary>
        public SearchOption Value { get; }

        public SearchOptionItem(string text, SearchOption value)
        {
            Text = text;
            Value = value;
        }

        public override string ToString() => Text;
    }
}