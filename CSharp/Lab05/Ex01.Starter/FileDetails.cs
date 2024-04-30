using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
    internal class FileDetails
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }
            Console.ReadLine();
        }

    }
}
