using System;
namespace Diamond
{
    public class Program
    {

            static int Main(string[] args)
            {
                if (args.Length > 0)
                {
                    var diamond = new Diamond(args[0][0]);
                    Console.WriteLine(diamond);
                }
                else
                {
                    Console.WriteLine("Please provide a letter as an argument.");
                }

                return 0;
            }
        }
    
}

