// This file was auto-generated by ML.NET Model Builder. 

using System;
using WindowsFormsApp1ML.Model;

namespace WindowsFormsApp1ML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                BeverageID = 1F,
                DayQuater = @"00시~04시",
                UserCount = 25F,
                DayOfTheWeek = @"월",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Usage with predicted Usage from sample data...\n\n");
            Console.WriteLine($"BeverageID: {sampleData.BeverageID}");
            Console.WriteLine($"DayQuater: {sampleData.DayQuater}");
            Console.WriteLine($"UserCount: {sampleData.UserCount}");
            Console.WriteLine($"DayOfTheWeek: {sampleData.DayOfTheWeek}");
            Console.WriteLine($"\n\nPredicted Usage: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}
