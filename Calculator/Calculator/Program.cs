using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Adder(7, 4));
            Console.WriteLine(Mult(5, 3));
            Console.WriteLine(Divide(8, 2));
            Console.ReadLine();
        }

        static int Adder(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
