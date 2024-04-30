using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.Utility
{
    internal class Utils
    {
        static void Main(string[] args)
        { bool ok;
          int answer;
          Console.Write("Please input a number ");
          int x = int.Parse(Console.ReadLine());
          ok = Utils.Factorial(x, out answer);
            if (ok)
                Console.WriteLine("Factorial(" + x + ") = " + answer);
            else
                Console.WriteLine("Cannot compute this factorial");
          Console.ReadLine();
        }
        public static bool Factorial(int n, out int f)
        {
            bool ok = true;
            f = 1;
            if (n < 0)
            { ok = false;
            }
            try
            {
                checked
                {
                    for (int i = 2; i <= n; ++i)
                    {
                        f = f * i;
                    }
                }
            }
            catch (Exception)
            {
                f = 0;
                ok = false;
            }
            int answer = f;
            return ok;
        }
    }
}
