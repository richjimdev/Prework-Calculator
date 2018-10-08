using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Adder(5, 7));
            Console.ReadLine();
        }

        static int Adder(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
