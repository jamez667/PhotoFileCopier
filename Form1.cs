using Newtonsoft.Json;
using System.ComponentModel;

namespace PhotoFileManager
{
    public partial class Form1 : Form
    {
        private ConfigSave config;
        public string configPath = "config.ini";

        public BindingList<FilePathListItem> inputs = new BindingList<FilePathListItem>();
        public BindingList<DirectoryListItem> outputs = new BindingList<DirectoryListItem>();

        public Form1()
        {
            InitializeComponent();
            loadConfig();
        }

        private void loadConfig()
        {
            config = new ConfigSave();
            if (File.Exists(configPath))
            {
                using (var reader = new StreamReader(configPath))
                {
                    string json = reader.ReadToEnd();
                    if (json != null)
                    {
                        var readConfig = JsonConvert.DeserializeObject<ConfigSave>(json);
                        if (readConfig != null)
                        {
                            config = readConfig;
                            if (config.InputDirectory != null || config.InputDirectory != "")
                            {
                                txtInputDirectory.Text = config.InputDirectory;
                            }
                            if (config.OutputDirectoryList != null && config.OutputDirectoryList.Count > 0)
                            {
                                foreach (var item in config.OutputDirectoryList)
                                {
                                    outputs.Add(new DirectoryListItem(item));
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                File.Create(configPath);
            }

            dataGridViewOutputDirectories.DataSource = outputs;
            dataGridViewInputFiles.DataSource = inputs;

            generateFileList(config.InputDirectory, config.InputFileTypes);
        }

        private void saveConfig()
        {
            File.WriteAllTextAsync(configPath, JsonConvert.SerializeObject(config));
        }

        private void generateFileList(string directoryPath, string[] fileTypes)
        {
            if (directoryPath == null || directoryPath == "")
                return;
            inputs.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
            foreach (var fileType in fileTypes)
            {
                FileInfo[] files = dirInfo.GetFiles(fileType, SearchOption.AllDirectories);
                foreach (FileInfo file in files)
                {
                    inputs.Add(new FilePathListItem(file));
                }
            }
        }

        private void copyAllFiles()
        {
            foreach (FilePathListItem file in inputs)
            {
                string creationYear = file.FileInfo.CreationTime.Year.ToString();
                string creationMonth = file.FileInfo.CreationTime.Month.ToString();
                string creationDay = file.FileInfo.CreationTime.Day.ToString();

                foreach (var output in config.OutputDirectoryList)
                {
                    var tagLibFile = TagLib.File.Create(file.FileInfo.FullName);
                    var tag = tagLibFile.Tag as TagLib.Image.CombinedImageTag;
                    var outputPath = Path.Combine(output, $"{file.FileInfo.Extension.TrimStart('.')}\\{creationYear}-{creationMonth.PadLeft(2, '0')}-{creationDay.PadLeft(2, '0')}");
                    if (tagLibFile.TagTypes != TagLib.TagTypes.None && tag != null)
                    {
                        outputPath = Path.Combine(output, $"{tag.Model}\\{creationYear}-{creationMonth.PadLeft(2, '0')}-{creationDay.PadLeft(2, '0')}");
                    }

                    Directory.CreateDirectory(outputPath);
                    try
                    {
                        file.FileInfo.CopyTo($"{outputPath}/{file.FileInfo.Name}", false);
                        Console.WriteLine($"{file.FileInfo.FullName} copied to {outputPath}");
                        listBoxConsole.Items.Add($"{file.FileInfo.FullName} copied to {outputPath}");
                    }
                    catch (IOException er)
                    {
                        listBoxConsole.Items.Add($"Error copying {file.FileInfo.FullName} to {outputPath} - {er.Message}");
                    }
                }
            }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            listBoxConsole.Items.Clear();
            copyAllFiles();
        }

        private void btnBrowseInputDirectory_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                config.InputDirectory = folderBrowserDialog1.SelectedPath;
                txtInputDirectory.Text = config.InputDirectory;
                generateFileList(config.InputDirectory, config.InputFileTypes);
                saveConfig();
            }

            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void btnBrowseOutputDirectory_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog4.ShowDialog();
            if (result == DialogResult.OK)
            {
                config.OutputDirectoryList.Add(folderBrowserDialog4.SelectedPath);
                outputs.Add(new DirectoryListItem(folderBrowserDialog4.SelectedPath));
                saveConfig();
            }

            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void dataGridViewOutputDirectories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != dataGridViewOutputDirectories.NewRowIndex)
            {
                // Maybe add are you sure popup
                dataGridViewOutputDirectories.Rows.RemoveAt(e.RowIndex);
            }
        }

    }
}