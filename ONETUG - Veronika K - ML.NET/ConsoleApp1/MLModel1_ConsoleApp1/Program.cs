﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace MLModel1_ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            string input = Console.ReadLine();

            // Create single instance of sample data from first line of dataset for model input
            MLModel1.ModelInput sampleData = new MLModel1.ModelInput()
            {
                SentimentText = input,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = MLModel1.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Sentiment with predicted Sentiment from sample data...\n\n");


            Console.WriteLine($"SentimentText: {sampleData.SentimentText}");


            Console.WriteLine($"\n\nPredicted Sentiment: {(predictionResult.Prediction == 1 ? "Toxic" : "Non-toxic")}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}