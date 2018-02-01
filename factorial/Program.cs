using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int original = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(original));
        }

        static int Factorial(int original)
        {
            int factorial = 1;
            for (int i = 1; i < original+1; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
        
    }
}