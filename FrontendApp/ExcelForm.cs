

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FolderHelpers.Classes;
using FrontendApp.Classes;

namespace FrontendApp
{
    public partial class ExcelForm : Form
    {
        public ExcelForm()
        {
            InitializeComponent();

            ActiveControl = ExecuteButton;

            FolderTextBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        }
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FolderTextBox1.Text)) return;

            if (!Directory.Exists(FolderTextBox1.Text))
            {
                return;
            }

            ErrorsListBox.Items.Clear();

            FileOperations operations = new();

            operations.OnNoAccess += OperationsOnOnNoAccess;

            var results = operations
                .EnumerateFilesSafe(
                    FolderTextBox1.Text,
                    "*.xlsx",
                    searchOptionComboBox1.SelectedOption().Value);

            operations.OnNoAccess -= OperationsOnOnNoAccess;

            ResultsListBox.DataSource = results.ToList();

        }

        private void OperationsOnOnNoAccess(string sender)
        {
            ErrorsListBox.Items.Add(sender);
        }
    }
}
