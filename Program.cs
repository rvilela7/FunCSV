using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace FunCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("* Get Params");
                string fileName = args.FirstOrDefault();
                if (!File.Exists(fileName)) //Default will not fire InvalididOperatorException
                {
                    throw new FileNotFoundException();
                }

                Console.WriteLine("* Get File Syntax");

                //FileStream Way
                using (FileStream file = new FileStream(fileName, FileMode.Open))
                {
                    // foreach (var fs in file.)
                    // {
                    // }
                }

                // #00132, B10, 100
                // #00343, B12, 200
                // #00120, B10, 200
                // #00156, B10, 600

                //Won't work due to dict only accepting a unique key
                //Dictionary<string, int> dicBatches = new Dictionary<string, int>();
                //Same issue for HashTAble
                List<KeyValuePair<string, int>> dicBatches = new List<KeyValuePair<string, int>>();
                dicBatches.Add(new KeyValuePair<string, int>("B10", 100));
                dicBatches.Add(new KeyValuePair<string, int>("B12", 200));
                dicBatches.Add(new KeyValuePair<string, int>("B10", 200));

                var dummyData = dicBatches.GroupBy(m => m.Key).ToList();

                List<KeyValuePair<string, int>> dicResult = new List<KeyValuePair<string, int>>();
                dicBatches.GroupBy(m => m.Key).ToList().ForEach(v => dicResult.Add(new KeyValuePair<string, int>(v.Key, v.Sum(r => r.Value))));

                Console.WriteLine("End");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
