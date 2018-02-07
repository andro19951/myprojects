using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string andro = Console.ReadLine();
            Console.Write(palindrome(andro));

        }

        static string palindrome(string andro)
        {
            for (int i = 0; i < andro.Length / 2; i++)
            {
                if (andro[i] != andro[andro.Length - i-1])
                {
                    return "not a palindrome!!!";
                }
                
            }

            return "palindrome";
        }
    }
}
