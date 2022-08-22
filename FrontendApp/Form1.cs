using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FolderHelpers.Classes;
using FrontendApp.Classes;

/*
 * An odd thing happened at one point and may happen to you
 * searchOptionComboBox1 disappeared when cloning it from the repo, had to remove it in code behind
 * and add it back in.
 */

namespace FrontendApp
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource = new();
        public Form1()
        {
            InitializeComponent();
            FormClosing += OnFormClosing;
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            cancellationTokenSource.Cancel();
        }

        private async void StartButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(FolderTextBox1.Text)) return;

            if (!Directory.Exists(FolderTextBox1.Text))
            {
                return;
            }

            if (cancellationTokenSource.IsCancellationRequested)
            {
                cancellationTokenSource.Dispose();
                cancellationTokenSource = new CancellationTokenSource();
            }

            progressBar1.Maximum = DirectoryHelpers.FileCount(FolderTextBox1.Text) +1;
            progressBar1.Value = 0;

            FileOperations operations = new();

            operations.Traverse += OperationsOnTraverse;
            operations.Done += OnDone;

            try
            {
                await operations.EnumerateFiles(FolderTextBox1.Text, "*.*", SearchOption.AllDirectories, cancellationTokenSource.Token);
            }
            catch (Exception exception)
            {
                if (exception is OperationCanceledException)
                {
                    Dialogs.AutoCloseDialog(this, Properties.Resources.Csharp, 3, "Operation cancelled");
                }
            }

            operations.Traverse -= OperationsOnTraverse;
            operations.Done -= OnDone;

        }

        private void OnDone()
        {
            Dialogs.AutoCloseDialog(this, Properties.Resources.Csharp, 2, "Done");
            progressBar1.Value = 0;
            label1.Text = "";
        }

        private void OperationsOnTraverse(string sender)
        {
            FileInfo info = new(sender);
            if (File.Exists(sender))
            {
                if (info.DirectoryName != null) label1.Text = Path.Combine(info.DirectoryName, info.Name);
                progressBar1.Value += 1;
            }
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label1.Text = "";
            cancellationTokenSource.Cancel();
        }

        private void GetFolderFileCountButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FolderTextBox2.Text)) return;

            if (!Directory.Exists(FolderTextBox2.Text))
            {
                return;
            }

            DirFolderCountTextBox.Text = "";

            var (directoryCount, fileCount) = DirectoryHelpers.DirectoryFileCount(FolderTextBox2.Text);

            DirFolderCountTextBox.Text = $@"Directory count: {directoryCount:N0} File count: {fileCount:N0}";

        }

        private void GetFileCountInDirectoryButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FolderForFileCountTextBox.Text)) return;

            if (!Directory.Exists(FolderForFileCountTextBox.Text))
            {
                return;
            }

            var (count, exception) = DirectoryHelpers.FileCountSafe(FolderForFileCountTextBox.Text, searchOptionComboBox1.SelectedOption().Value);
            if (exception is null)
            {
                Dialogs.AutoCloseDialog(this, Properties.Resources.Csharp, 5, $"File count: {count:N0}", "");
            }
            else
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FolderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
