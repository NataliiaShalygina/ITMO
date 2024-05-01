using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Utils
{
    class Test
    {
        static void Main()
        {
            string message;

            // Get an input string
            Console.WriteLine("Enter string to reverse:");
            message = Console.ReadLine();

            // Reverse the string
            Utils.Reverse(ref message);

            // Display the result
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
