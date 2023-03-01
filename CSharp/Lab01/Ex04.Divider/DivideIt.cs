using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Divider
{
    internal class DivideIt
    {
        static void Main(string[] args)
            {
                string temp;
                try
                {
                    Console.WriteLine("Please enter first number, i=");
                    temp = Console.ReadLine();
                    int i = Int32.Parse(temp);
                    Console.WriteLine("Please enter second number, j=");
                    temp = Console.ReadLine();
                    int j = Int32.Parse(temp);
                    int k = i / j;
                    Console.WriteLine("i/j={0}", k);
                    temp = Console.ReadLine();
                }

                catch (Exception e)
                { Console.WriteLine("An exception was thrown: {0}", e); Console.ReadLine(); }
            }
        }
    }
   
