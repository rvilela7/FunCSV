using System;
using System.Linq;

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
                
                MainClasses.ExerciseCSVFile exercise = new MainClasses.ExerciseCSVFile();

                exercise.RunExercise(fileName);

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
