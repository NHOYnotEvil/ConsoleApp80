using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int maxNumber = 27;
            int minimumThreedigitNumber = 100;
            int maximumThreedigitNumber = 999;
            int countsNumberMultiples = 0;

            number = random.Next(maxNumber);

            Console.WriteLine("Ваше число - " + number + ".");

            for (int i = 0; i <= maximumThreedigitNumber; i += number)
            {
                if (i >= minimumThreedigitNumber)
                {
                    countsNumberMultiples++; 
                }
            }

            Console.WriteLine("колличество трёхзначных чисел, кратных " + number + ", равно - " + countsNumberMultiples + ".");
        }
    }
}