using System;

namespace ArrayManiupulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //int[,] A = new int[3,3] { { 12, 8,  4}, { 3,  17, 14}, { 9,  8,  10} };
            //int[,] B = new int[3, 3] { { 5, 19, 3 }, { 6, 15, 9 }, { 7, 8,  16 } };

            //int[,] result = ManipulateArray(A, B);

            //Console.WriteLine(result[1,1]);


           //int[] array = GetPrimeNumbers(30);

           // for (int i = 0; i < array.Length; i++)
           // {
           //     Console.WriteLine(array[i]);
           // }

           // Console.WriteLine("Done");

            //Console.WriteLine(IsThisAPalindrome("RACECAR"));

            Console.WriteLine(IsPalindrome("RACE CAR"));

        }

        // Refactoring Code 03/27/2023
        // Actually easy to undestand the reverse word instead to reading in 2 ways and work with a full sentense :(
        public static bool IsPalindrome(string text)
        {
            string tempText = new string(text.Where(t => char.IsLetterOrDigit(t)).Select(char.ToLower) .ToArray());

            //Console.WriteLine(tempText);
            //Console.WriteLine(new string(tempText.Reverse().ToArray()));

            return tempText == new string(tempText.Reverse().ToArray());
        }

        public static bool IsThisAPalindrome(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            int i = 0; // Here I mess with the 1 :(
            int j = text.Length - 1;

            while (i < j)
                {
                Console.WriteLine(text[i]);
                Console.WriteLine(text[j]);

                if (text[i++] != text[j--])
                {
                    return false;
                }
            }

            return true;
        }


        public static int[] GetPrimeNumbers(int n)
        {
            List<int> primes = new();

            for (int i = 0; i < n; i++)
            {
                if (IsPrimeNumber(i))
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray();
        }

        // Refactoring Code 03/27/2023
        // Not so dark method about to increment in pairs or work with the floor :( Clean and easy mode to do not mess again with a technical interview
        public static bool isPrimerNumber2(int number)
        {
            if (number < 2) return false;

            int sqrt = (int)Math.Sqrt(number);

            for (int i = 2; i < sqrt; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool IsPrimeNumber(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            int boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i < boundary; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int[,] ManipulateArray(int[,] A, int[,] B)
        {
            int[,] result = new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; i < 3; i++)
                {
                    int sum = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        sum += A[i, k] * B[k, j];
                    }

                    result[i, j] = sum;
                }
            }

            return result;
        }
    }
}