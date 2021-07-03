using System;

namespace CSharpOverFlowExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 65445789;
            int b = 7896;

            checked
            {
                try
                {
                    while (true)
                    {
                        a = a * b;
                        Console.WriteLine(a);
                    }
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.ToString());
                }
            }// end checked
        }
    }
}
