using System;

namespace Starter
{
    public class Application
    {
        public static void Main(string[] args)
        {
            try
            {
                InnerMain(args);
            }
            catch (System.Exception caught)
            {
                Console.WriteLine(caught);
            }
        }

        public static void InnerMain(string[] args)
        {
            SourceFile source = new SourceFile(args[0]);

            HTML_token_visitor visitor = new HTML_token_visitor();
            source.Accept(visitor);
        }
    }
}
