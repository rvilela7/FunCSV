namespace FunCSV
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Start");
                
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
