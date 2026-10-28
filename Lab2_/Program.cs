using System;

namespace Lab2
{
    class Program
    {
        public static int ToMultiplicate(int x, int n = 2)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += x;
            }
            return sum;
        }

        public static double ToMultiplicate(double x, int n = 2)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += x;
            }
            return sum;
        }

        public static string ToMultiplicate(string x, int n = 2)
        {
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += x;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int intResult1 = ToMultiplicate(5, 3);
            int intResult2 = ToMultiplicate(5);

            double doubleResult1 = ToMultiplicate(4.5, 3);
            double doubleResult2 = ToMultiplicate(4.5);

            string stringResult1 = ToMultiplicate("A", 4);
            string stringResult2 = ToMultiplicate("Test");

            Console.WriteLine($"Int (5, 3): {intResult1}");
            Console.WriteLine($"Int default (5): {intResult2}");
            Console.WriteLine($"Double (4.5, 3): {doubleResult1}");
            Console.WriteLine($"Double default (4.5): {doubleResult2}");
            Console.WriteLine($"String (\"A\", 4): {stringResult1}");
            Console.WriteLine($"String default (\"Test\"): {stringResult2}");

            Console.ReadKey();
        }
    }
}