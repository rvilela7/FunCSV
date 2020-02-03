namespace FileClasses
{
    using System.IO;
    using Microsoft.VisualBasic; //Name Space specific

    public class ReaderCSV : IReaderCSV
    {
        public void OpenFile(string fileName)
        {

            if (!File.Exists(fileName)) //Default will not fire InvalididOperatorException
            {
                throw new FileNotFoundException();
            }
        }

        public string ReadCSV()
        {
            //FileStream Way


            // #00132, B10, 100
            // #00343, B12, 200
            // #00120, B10, 200
            // #00156, B10, 600

            return null;
        }
    }
}