using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01.Utility
{
    internal class Utility
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int greater;
            Console.WriteLine("Enter first number:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            y = int.Parse(Console.ReadLine());
            greater = Utility.Greater(x, y);
            Console.WriteLine("The greater value is " + greater);
            Console.ReadLine();
        }
        public static int Greater(int a, int b)
        {
             if (a > b)  
                    return a;
             else
                    return b;
        }

    }
}
