namespace MainClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FileClasses;
    public class ExerciseCSVFile
    {
        public void RunExercise(string fileName)
        {
            Console.WriteLine("* Get File Syntax");
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
    }
}