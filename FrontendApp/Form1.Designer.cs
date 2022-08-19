
namespace FrontendApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.FolderTextBox1 = new System.Windows.Forms.TextBox();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.StartButton1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DirFolderCountTextBox = new System.Windows.Forms.TextBox();
            this.GetFolderFileCountButton = new System.Windows.Forms.Button();
            this.FolderTextBox2 = new System.Windows.Forms.TextBox();
            this.searchOptionComboBox1 = new FrontendApp.Classes.SearchOptionComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GetFileCountInDirectoryButton = new System.Windows.Forms.Button();
            this.FolderForFileCountTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.FolderTextBox1);
            this.groupBox1.Controls.Add(this.CancelButton1);
            this.groupBox1.Controls.Add(this.StartButton1);
            this.groupBox1.Location = new System.Drawing.Point(19, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(557, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traverse folder with cancellation and progressbar";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(113, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(113, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(429, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // FolderTextBox1
            // 
            this.FolderTextBox1.Location = new System.Drawing.Point(113, 36);
            this.FolderTextBox1.Name = "FolderTextBox1";
            this.FolderTextBox1.PlaceholderText = "Enter a valid path for work with";
            this.FolderTextBox1.Size = new System.Drawing.Size(429, 23);
            this.FolderTextBox1.TabIndex = 2;
            this.FolderTextBox1.Text = "C:\\OED\\Dotnetland\\VS2019\\FolderSolution";
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(20, 64);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(75, 23);
            this.CancelButton1.TabIndex = 1;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // StartButton1
            // 
            this.StartButton1.Location = new System.Drawing.Point(20, 35);
            this.StartButton1.Name = "StartButton1";
            this.StartButton1.Size = new System.Drawing.Size(75, 23);
            this.StartButton1.TabIndex = 0;
            this.StartButton1.Text = "Start";
            this.StartButton1.UseVisualStyleBackColor = true;
            this.StartButton1.Click += new System.EventHandler(this.StartButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DirFolderCountTextBox);
            this.groupBox2.Controls.Add(this.GetFolderFileCountButton);
            this.groupBox2.Controls.Add(this.FolderTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(19, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get directory and file count";
            // 
            // DirFolderCountTextBox
            // 
            this.DirFolderCountTextBox.Location = new System.Drawing.Point(113, 53);
            this.DirFolderCountTextBox.Name = "DirFolderCountTextBox";
            this.DirFolderCountTextBox.PlaceholderText = "Results for diectory and file count";
            this.DirFolderCountTextBox.Size = new System.Drawing.Size(413, 23);
            this.DirFolderCountTextBox.TabIndex = 7;
            // 
            // GetFolderFileCountButton
            // 
            this.GetFolderFileCountButton.Location = new System.Drawing.Point(20, 24);
            this.GetFolderFileCountButton.Name = "GetFolderFileCountButton";
            this.GetFolderFileCountButton.Size = new System.Drawing.Size(75, 23);
            this.GetFolderFileCountButton.TabIndex = 6;
            this.GetFolderFileCountButton.Text = "Execute";
            this.GetFolderFileCountButton.UseVisualStyleBackColor = true;
            this.GetFolderFileCountButton.Click += new System.EventHandler(this.GetFolderFileCountButton_Click);
            // 
            // FolderTextBox2
            // 
            this.FolderTextBox2.Location = new System.Drawing.Point(113, 24);
            this.FolderTextBox2.Name = "FolderTextBox2";
            this.FolderTextBox2.PlaceholderText = "Enter a valid path for work with";
            this.FolderTextBox2.Size = new System.Drawing.Size(413, 23);
            this.FolderTextBox2.TabIndex = 5;
            this.FolderTextBox2.Text = "C:\\OED\\Dotnetland\\VS2019\\FolderSolution";
            // 
            // searchOptionComboBox1
            // 
            this.searchOptionComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOptionComboBox1.FormattingEnabled = true;
            this.searchOptionComboBox1.Location = new System.Drawing.Point(113, 35);
            this.searchOptionComboBox1.Name = "searchOptionComboBox1";
            this.searchOptionComboBox1.Size = new System.Drawing.Size(173, 23);
            this.searchOptionComboBox1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FolderForFileCountTextBox);
            this.groupBox3.Controls.Add(this.searchOptionComboBox1);
            this.groupBox3.Controls.Add(this.GetFileCountInDirectoryButton);
            this.groupBox3.Location = new System.Drawing.Point(19, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(556, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Count files in directory";
            // 
            // GetFileCountInDirectoryButton
            // 
            this.GetFileCountInDirectoryButton.Location = new System.Drawing.Point(20, 34);
            this.GetFileCountInDirectoryButton.Name = "GetFileCountInDirectoryButton";
            this.GetFileCountInDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.GetFileCountInDirectoryButton.TabIndex = 0;
            this.GetFileCountInDirectoryButton.Text = "Execute";
            this.GetFileCountInDirectoryButton.UseVisualStyleBackColor = true;
            this.GetFileCountInDirectoryButton.Click += new System.EventHandler(this.GetFileCountInDirectoryButton_Click);
            // 
            // FolderForFileCountTextBox
            // 
            this.FolderForFileCountTextBox.Location = new System.Drawing.Point(113, 64);
            this.FolderForFileCountTextBox.Name = "FolderForFileCountTextBox";
            this.FolderForFileCountTextBox.PlaceholderText = "Enter a valid path for work with";
            this.FolderForFileCountTextBox.Size = new System.Drawing.Size(413, 23);
            this.FolderForFileCountTextBox.TabIndex = 8;
            this.FolderForFileCountTextBox.Text = "C:\\OED\\Dotnetland\\VS2019\\FolderSolution";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 433);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code samples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Button StartButton1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox FolderTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetFolderFileCountButton;
        private System.Windows.Forms.TextBox FolderTextBox2;
        private System.Windows.Forms.TextBox DirFolderCountTextBox;
        private Classes.SearchOptionComboBox searchOptionComboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox FolderForFileCountTextBox;
        private System.Windows.Forms.Button GetFileCountInDirectoryButton;
    }
}

