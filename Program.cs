using System;

namespace failing_code
{
    class Program
    {
        static void Main(string[] args)
        {

            int max = int.Parse(args[0]);
            
            var printer = new Printer(Console.Out);

            for (int i = 0; i < max; i++)
            {
                if ((i % 3) == 0 && ((i % 5) == 0))
                {
                    printer.PrintResult(true, true);
                }
                else if ((i % 3) == 0)
                {
                    printer.PrintResult(true, false);
                }
                else if ((i % 5) == 0)
                {
                    printer.PrintResult(false, true);
                }
                else
                {
                    Console.WriteLine(i);
                }
                //Console.Write("\n");
            }
        }
    }
}
