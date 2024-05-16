using System.ComponentModel.Design;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature");
            string userInput = Console.ReadLine();

            int temp = Convert.ToInt32(userInput);
            if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp >= 11 && temp <= 20)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp >= 21 && temp <= 35)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp >= 36 && temp <= 50)
            {
                Console.WriteLine("Normal in weather");
            }
            else if (temp >= 51 && temp <= 65)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temp >= 66 && temp <= 80)
            {
                Console.WriteLine("Its Very Hot");
            }
            else
            {
                Console.WriteLine("Temperature is unknown");
            }

        }

     
    }

}


