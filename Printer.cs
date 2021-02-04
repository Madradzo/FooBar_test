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
                _output.Write("FooBar");
            }
            else if (foo)
            {
                _output.Write("Foo");
            }
            else if (bar)
            {
                _output.Write("Bar");
            }
            else
            {
                _output.Write("----");
            }
        }
    }
}
