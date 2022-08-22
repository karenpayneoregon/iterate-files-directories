namespace FrontendApp
{
    partial class ExcelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.FolderTextBox1 = new System.Windows.Forms.TextBox();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.ResultsListBox = new System.Windows.Forms.ListBox();
            this.ErrorsListBox = new System.Windows.Forms.ListBox();
            this.searchOptionComboBox1 = new FrontendApp.Classes.SearchOptionComboBox();
            this.SuspendLayout();
            // 
            // FolderTextBox1
            // 
            this.FolderTextBox1.Location = new System.Drawing.Point(105, 12);
            this.FolderTextBox1.Name = "FolderTextBox1";
            this.FolderTextBox1.PlaceholderText = "Enter a valid path for work with";
            this.FolderTextBox1.Size = new System.Drawing.Size(397, 23);
            this.FolderTextBox1.TabIndex = 4;
            this.FolderTextBox1.Text = "C:\\Users\\paynek\\Documents";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(12, 12);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 7;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // ResultsListBox
            // 
            this.ResultsListBox.FormattingEnabled = true;
            this.ResultsListBox.ItemHeight = 15;
            this.ResultsListBox.Location = new System.Drawing.Point(12, 55);
            this.ResultsListBox.Name = "ResultsListBox";
            this.ResultsListBox.Size = new System.Drawing.Size(670, 154);
            this.ResultsListBox.TabIndex = 8;
            // 
            // ErrorsListBox
            // 
            this.ErrorsListBox.FormattingEnabled = true;
            this.ErrorsListBox.ItemHeight = 15;
            this.ErrorsListBox.Location = new System.Drawing.Point(12, 215);
            this.ErrorsListBox.Name = "ErrorsListBox";
            this.ErrorsListBox.Size = new System.Drawing.Size(670, 154);
            this.ErrorsListBox.TabIndex = 9;
            // 
            // searchOptionComboBox1
            // 
            this.searchOptionComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchOptionComboBox1.FormattingEnabled = true;
            this.searchOptionComboBox1.Location = new System.Drawing.Point(511, 12);
            this.searchOptionComboBox1.Name = "searchOptionComboBox1";
            this.searchOptionComboBox1.Size = new System.Drawing.Size(173, 23);
            this.searchOptionComboBox1.TabIndex = 10;
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.searchOptionComboBox1);
            this.Controls.Add(this.ErrorsListBox);
            this.Controls.Add(this.ResultsListBox);
            this.Controls.Add(this.ExecuteButton);
            this.Controls.Add(this.FolderTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExcelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unauthorized Access Exception example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolderTextBox1;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.ListBox ResultsListBox;
        private System.Windows.Forms.ListBox ErrorsListBox;
        private Classes.SearchOptionComboBox searchOptionComboBox1;
    }
}