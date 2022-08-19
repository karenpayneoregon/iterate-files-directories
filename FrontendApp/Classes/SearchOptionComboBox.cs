using System.Drawing;
using System.Windows.Forms;
using FolderHelpers.Classes;

namespace FrontendApp.Classes
{
    public class SearchOptionComboBox : ComboBox
    {
        public SearchOptionComboBox()
        {
            Size = new Size(173, 23);
            DropDownStyle = ComboBoxStyle.DropDownList;
            DataSource = FileOperations.SearchOptions();
        }

        public SearchOptionItem SelectedOption() => (SearchOptionItem)SelectedItem;
    }
}
