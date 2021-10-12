using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String startString = Console.ReadLine();
            for (int i = 0; i < startString.Length; i++)
            {

                if (startString[i] == '{')
                {
                    for (int j = i + 1; j < startString.Length; j++)
                    {
                        if (startString[j] == '}')
                        {

                            startString = startString.Substring(0, i) + startString.Substring(j + 1);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(startString);
            Console.ReadKey();
        }
    }
}


