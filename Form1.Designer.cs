namespace PhotoFileManager
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
            txtInputDirectory = new TextBox();
            btnCopy = new Button();
            btnBrowseInputDirectory = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            dataGridViewOutputDirectories = new DataGridView();
            btnBrowseOutputDirectory = new Button();
            folderBrowserDialog2 = new FolderBrowserDialog();
            folderBrowserDialog3 = new FolderBrowserDialog();
            folderBrowserDialog4 = new FolderBrowserDialog();
            dataGridViewInputFiles = new DataGridView();
            listBoxConsole = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputDirectories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputFiles).BeginInit();
            SuspendLayout();
            // 
            // txtInputDirectory
            // 
            txtInputDirectory.Location = new Point(15, 28);
            txtInputDirectory.Name = "txtInputDirectory";
            txtInputDirectory.Size = new Size(257, 23);
            txtInputDirectory.TabIndex = 1;
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(359, 229);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 23);
            btnCopy.TabIndex = 3;
            btnCopy.Text = "Copy >>";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnBrowseInputDirectory
            // 
            btnBrowseInputDirectory.Location = new Point(278, 27);
            btnBrowseInputDirectory.Name = "btnBrowseInputDirectory";
            btnBrowseInputDirectory.Size = new Size(75, 23);
            btnBrowseInputDirectory.TabIndex = 4;
            btnBrowseInputDirectory.Text = "Browse";
            btnBrowseInputDirectory.UseVisualStyleBackColor = true;
            btnBrowseInputDirectory.Click += btnBrowseInputDirectory_Click;
            // 
            // dataGridViewOutputDirectories
            // 
            dataGridViewOutputDirectories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOutputDirectories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutputDirectories.Location = new Point(440, 56);
            dataGridViewOutputDirectories.MultiSelect = false;
            dataGridViewOutputDirectories.Name = "dataGridViewOutputDirectories";
            dataGridViewOutputDirectories.RowHeadersVisible = false;
            dataGridViewOutputDirectories.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewOutputDirectories.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOutputDirectories.Size = new Size(348, 368);
            dataGridViewOutputDirectories.TabIndex = 5;
            dataGridViewOutputDirectories.CellDoubleClick += dataGridViewOutputDirectories_CellDoubleClick;
            // 
            // btnBrowseOutputDirectory
            // 
            btnBrowseOutputDirectory.Location = new Point(440, 27);
            btnBrowseOutputDirectory.Name = "btnBrowseOutputDirectory";
            btnBrowseOutputDirectory.Size = new Size(348, 23);
            btnBrowseOutputDirectory.TabIndex = 6;
            btnBrowseOutputDirectory.Text = "Add Output Directory";
            btnBrowseOutputDirectory.UseVisualStyleBackColor = true;
            btnBrowseOutputDirectory.Click += btnBrowseOutputDirectory_Click;
            // 
            // dataGridViewInputFiles
            // 
            dataGridViewInputFiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInputFiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInputFiles.Location = new Point(15, 56);
            dataGridViewInputFiles.MultiSelect = false;
            dataGridViewInputFiles.Name = "dataGridViewInputFiles";
            dataGridViewInputFiles.RowHeadersVisible = false;
            dataGridViewInputFiles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewInputFiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInputFiles.Size = new Size(338, 368);
            dataGridViewInputFiles.TabIndex = 7;
            // 
            // listBoxConsole
            // 
            listBoxConsole.FormattingEnabled = true;
            listBoxConsole.ItemHeight = 15;
            listBoxConsole.Location = new Point(15, 434);
            listBoxConsole.Name = "listBoxConsole";
            listBoxConsole.Size = new Size(773, 109);
            listBoxConsole.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 555);
            Controls.Add(listBoxConsole);
            Controls.Add(dataGridViewInputFiles);
            Controls.Add(btnBrowseOutputDirectory);
            Controls.Add(dataGridViewOutputDirectories);
            Controls.Add(btnBrowseInputDirectory);
            Controls.Add(btnCopy);
            Controls.Add(txtInputDirectory);
            Name = "Form1";
            Text = "PhotoFileMover";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutputDirectories).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInputFiles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtInputDirectory;
        private Button btnCopy;
        private Button btnBrowseInputDirectory;
        private FolderBrowserDialog folderBrowserDialog1;
        private DataGridView dataGridViewOutputDirectories;
        private Button btnBrowseOutputDirectory;
        private FolderBrowserDialog folderBrowserDialog2;
        private FolderBrowserDialog folderBrowserDialog3;
        private FolderBrowserDialog folderBrowserDialog4;
        private DataGridView dataGridViewInputFiles;
        private ListBox listBoxConsole;
    }
}
