using System;
using CatAndDogAiML.Model;

namespace CatAndDogAi
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            bool DoWhile = true;
            do
            {
                try
                {
                    // Add input data
                    var input = new ModelInput();
                    Console.WriteLine("Insert file directory");
                    Console.Write("<user>:");
                    input.ImageSource = Convert.ToString(Console.ReadLine());
                    ModelOutput result = ConsumeModel.Predict(input);
                    Console.Write("\r\n");
                    Console.WriteLine($"Result:{result.Prediction} Accuracy {result.Score}");
                    Console.WriteLine($"Continue? (Y/N)");
                    Console.Write("<user>:");
                    answer = Convert.ToString(Console.ReadLine());

                    if (answer.ToLower() == "n")
                    {
                        DoWhile = false;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Exception found: " + e);
                }
                
            } while (DoWhile);
        }
    }
}
