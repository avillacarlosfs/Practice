using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class ArithmeticOperation
    {
        public virtual int Operation(int x, int b)
        {
            Console.WriteLine("adding", x, b);
            return x + b;
        }
    }
    class Addition: ArithmeticOperation
    {
        public override int Operation(int x, int b)
        {
            return x + b;
        }
    }
    class Substraction: ArithmeticOperation
    {
        public override int Operation(int x, int b)
        {
            return x - b;
        }
    }

    class Multiplication: ArithmeticOperation
    {
        public override int Operation(int x, int b)
        {
            return x * b; 
        }
    }

}
