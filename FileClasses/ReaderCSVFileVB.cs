namespace FileClasses
{
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.VisualBasic.FileIO;

    public class ReaderCSV : IReaderCSV
    {
        private readonly string _fileName;

        public ReaderCSV(string fileName)
        {
            _fileName = fileName;
        }

        public string GetFileName => _fileName;
        public bool IsFile() => File.Exists(_fileName);

        public IEnumerable<KeyValuePair<string, int>> ReadCSV()
        {
            using (TextFieldParser parser = new TextFieldParser(_fileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields)
                    {

                    }
                }
            }


            // #00132, B10, 100
            // #00343, B12, 200
            // #00120, B10, 200
            // #00156, B10, 600

            return null;
        }
    }
}