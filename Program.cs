using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ArithmeticOperation addOp = new Addition();
            Console.WriteLine(addOp.Operation(1, 2));
        }
    }
}
