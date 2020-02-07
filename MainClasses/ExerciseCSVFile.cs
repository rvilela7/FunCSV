namespace MainClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using FileClasses;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    public class ExerciseCSVFile
    {
        public void RunExercise(string fileName)
        {

            var collection = new ServiceCollection();
            collection.AddScoped<IReaderCSV, ReaderCSV>();
            // ...
            // Add other services
            // ...
            var serviceProvider = collection.BuildServiceProvider();
            var service = serviceProvider.GetService<IReaderCSV>();
            //service.DoSomething();

            Console.WriteLine("-> Get File Content");
            //Won't work due to dict only accepting a unique key
            //Dictionary<string, int> dicBatches = new Dictionary<string, int>();
            //Same issue for HashTAble

            // Example to mockup       
            // List<KeyValuePair<string, int>> dicBatches = new List<KeyValuePair<string, int>>();
            // dicBatches.Add(new KeyValuePair<string, int>("B10", 100));
            // dicBatches.Add(new KeyValuePair<string, int>("B12", 200));
            // dicBatches.Add(new KeyValuePair<string, int>("B10", 200));
            
            if (!service.SetFile(fileName))
                throw new Exception($"Could not open file {fileName}");

            var dicBatches = service.ReadCSV();

            //var dummyData = dicBatches.GroupBy(m => m.Key).ToList();

            List<KeyValuePair<string, int>> dicResult = new List<KeyValuePair<string, int>>();
            dicBatches.GroupBy(m => m.Key).ToList().ForEach(v => dicResult.Add(new KeyValuePair<string, int>(v.Key, v.Sum(r => r.Value))));

            dicResult.ForEach(m => Console.WriteLine($"\tKey:{m.Key} -> {m.Value}"));

            Console.WriteLine("End");
        }
    }
}