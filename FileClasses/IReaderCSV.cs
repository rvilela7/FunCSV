using System.Collections.Generic;

namespace FileClasses
{
    public interface IReaderCSV
    {
        bool SetFile(string filename);
        List<KeyValuePair<string, int>> ReadCSV();
    }
}