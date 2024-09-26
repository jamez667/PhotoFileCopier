namespace PhotoFileManager
{
    public class FilePathListItem
    {
        public FileInfo FileInfo { get; private set; }

        public FilePathListItem(FileInfo fileInfo)
        {
            FileInfo = fileInfo;
        }
    }
}