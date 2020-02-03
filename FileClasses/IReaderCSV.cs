using System.Collections.Generic;

namespace FileClasses
{
    public interface IReaderCSV
    {
        string GetFileName { get; }
        bool IsFile();
        IEnumerable<KeyValuePair<string, int>> ReadCSV();
    }
}