using System;

namespace ReverseInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int original = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ReverseInteger(original));
        }

        static int ReverseInteger(int original)
        {
            int Reversedata=0;
            for (int i = 0; Math.Pow(10, i) <= original; i++)
            {
                Console.WriteLine("I'm here suckka!");
                Reversedata = Reversedata *10 + (original % Convert.ToInt32(Math.Pow(10, i+1))-original % Convert.ToInt32(Math.Pow(10, i)))/Convert.ToInt32(Math.Pow(10, i));
            }
            return Reversedata;
        }
    }
}