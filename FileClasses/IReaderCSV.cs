namespace FileClasses
{
    public interface IReaderCSV
    {
        void OpenFile(string fileName);
        string ReadCSV();
    }
}