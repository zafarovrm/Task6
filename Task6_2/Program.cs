using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String startString = Console.ReadLine();
            startString = startString.ToLower();
            startString = startString.Replace(" ", "");
            string reverseString = "";
            for (int i = startString.Length - 1; i >= 0; i--)
            {
                reverseString += startString[i]; 
            }
            if (startString != reverseString)
            {
                Console.WriteLine("Эта строка - не палиндром");
            }
            else
            {
                Console.WriteLine("Эта строка - палиндром");
            }
            Console.ReadKey();
        }
    }
}