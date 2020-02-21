using System;
using CatAndDogAiML.Model;

namespace CatAndDogAi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------\r\n| By Nico. | \r\n------------\r\n");
            string answer;
            bool DoWhile = true;
            do
            {
                // Add input data
                var input = new ModelInput();
                Console.WriteLine("Insert file directory");
                Console.Write("<user>:");
                input.ImageSource = Convert.ToString(Console.ReadLine());
                ModelOutput result = ConsumeModel.Predict(input);
                Console.Write("\r\n");
                Console.WriteLine($"Result:{result.Prediction}");
                Console.WriteLine($"Continue? (Y/N)");
                Console.Write("<user>:");
                answer = Convert.ToString(Console.ReadLine());
                
                if (answer.ToLower() == "n")
                {
                    DoWhile = false;
                }
            } while (DoWhile);
        }
    }
}
