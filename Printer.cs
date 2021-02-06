using System.IO;

namespace failing_code
{
    public class Printer
    {
        private readonly TextWriter _output;

        public Printer(TextWriter output)
        {
            _output = output;
        }

        public void PrintResult(bool foo, bool bar)
        {
            
            if (foo && bar)
            {
                _output.WriteLine("FizzBuzz");
            }
            else if (foo)
            {
                _output.WriteLine("Fizz");
            }
            else
            {
                _output.WriteLine("Buzz");
            }
        }
    }
}
