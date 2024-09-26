namespace PhotoFileManager
{
    public class DirectoryListItem
    {
        public string Directory { get; private set; }

        public DirectoryListItem(string directory)
        {
            Directory = directory;
        }
    }
}