using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    abstract public class ArithmeticOperation
    {
        abstract public int Operation(int x, int b);
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
            return x*b;
        }
    }

}
