namespace FileClasses
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Microsoft.VisualBasic.FileIO;

    // #00132, B10, 100
    // #00343, B12, 200
    // #00120, B10, 200
    // #00156, B10, 600

    public class ReaderCSV : IReaderCSV
    {
        public string FileName { get; set; }
        public bool SetFile(string fileName)
        {
            if (!File.Exists(fileName))
                return false;
            
            FileName = fileName;
            return true;
        }

        public List<KeyValuePair<string, int>> ReadCSV()
        {
            using (TextFieldParser parser = new TextFieldParser(FileName))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                List<KeyValuePair<string, int>> valuePairs = new List<KeyValuePair<string, int>>();
                try
                {
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        valuePairs.Add(new KeyValuePair<string, int>(fields[1], int.Parse(fields[2])));
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                return valuePairs;
            }
        }
    }
}