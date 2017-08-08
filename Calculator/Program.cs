using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num3, int num4)
        {
            return num3 - num4;
        }

        public int Multiply(int num5, int num6)
        {
            return num5 * num6;
        }

        public int Divide(int num7, int num8)
        {
            return num7 / num8;
        }
    }
}
