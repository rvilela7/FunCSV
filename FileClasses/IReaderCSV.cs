using System.Collections.Generic;

namespace FileClasses
{
    public interface IReaderCSV
    {
        bool IsFile();
        IEnumerable<KeyValuePair<string, int>> ReadCSV();
    }
}