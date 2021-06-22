using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace bai4
{
    class PrimeNumber
    {
        public static void Main(string[] args)
        {
            GeneratePrimeNumbersAsync();
        }
        private static async void GeneratePrimeNumbersAsync()
        {

            const int minimum = 2, maximum = 100;

            var resultCollection = await ValidatePrimesAsync(minimum, maximum);

            int[] sortedPrimes = resultCollection.ToArray();

            Console.WriteLine("All Prime Numbers from 2 to:" + maximum);
            Console.Write("2"); 

            for (int i = 0; i < sortedPrimes.Length; i++)
                Console.Write($" {sortedPrimes[i] }");

            Console.WriteLine("\nPress any key to quit...");
            Console.ReadKey();

        }

        private static async Task<List<int>> ValidatePrimesAsync(int minimum, int maximum)
        {
            var count = maximum - minimum + 1;

            bool val = false;
            List<int> resultCollection = new List<int>();
            for (int i = minimum; i <= count; i++)
            {
                val = IsPrime(i);

                if (val == true)
                    resultCollection.Add(i);
            }

            return resultCollection;
        }


        static bool IsPrime(int num)
        {
            if (num % 2 == 0)
                return false;

            int temp = (int)Math.Sqrt(num);

            for (int i = 3; i <= temp; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            // Console.WriteLine( num + "is" + "prime");
            return true;
        }
    }
}