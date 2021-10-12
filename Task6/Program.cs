using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            String StartString = Console.ReadLine();
            String[] StringArray = StartString.Split();
            String resultString = "";
            for (int i = 0; i < StringArray.Length; i++)
            {
                if (StringArray[i].Length > resultString.Length)
                    resultString = StringArray[i];
            }
            Console.WriteLine("Самое длинное слово в строке {0}", resultString);
            Console.ReadKey();
        }        
    }    
}


            