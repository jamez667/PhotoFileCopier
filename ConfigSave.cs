namespace PhotoFileManager
{
    public class ConfigSave
    {
        public List<string> OutputDirectoryList { get; set; }
        public string InputDirectory { get; set; }
        public string[] InputFileTypes { get; private set; }

        public ConfigSave()
        {
            OutputDirectoryList = new List<string>();
            InputDirectory = "";
            InputFileTypes = ["*.nef", "*.orf", "*.cr2"];
        }
    }
}