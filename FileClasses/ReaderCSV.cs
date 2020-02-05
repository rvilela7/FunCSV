namespace FileClasses
{
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.VisualBasic.FileIO;

    public class ReaderCSV : IReaderCSV
    {
        public string FileName { get; set; }

        
        public bool IsFile() => File.Exists(FileName);

        public IEnumerable<KeyValuePair<string, int>> ReadCSV()
        {
            using (TextFieldParser parser = new TextFieldParser(FileName))
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