using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02.Utils
{
    class Utils
    {
        //
        // Return the greater of two integer values
        //
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static bool Factorial(int n, out int answer)
        {
            int k; // Loop counter
            int f; // Working value
            bool ok = true; // True if okay, false if not
                            // Check the input value
            if (n < 0)
                ok = false;

            // Calculate the factorial value as the
            // product of all of the numbers from 2 to n

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f *= k;
                    }
                }
            }
            catch (Exception)
            {
                // If something goes wrong in the calculation,
                // catch it here. All exceptions
                // are handled the same way: set the result
                // to zero and return false.
                f = 0;
                ok = false;
            }

            // Assign result value
            answer = f;
            // Return to caller
            return ok;
        }

        public static void Reverse(ref string s)
        {
            string sRev = "";

            for (int k = s.Length - 1; k >= 0; k--)
                sRev = sRev + s[k];

            // Return result to caller
            s = sRev;
        }
    }
}
