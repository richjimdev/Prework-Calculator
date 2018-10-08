using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What calculator function would you like to perform?");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            string selection = Console.ReadLine();

            Console.WriteLine("Input two numbers to calculate your final result:");
            int firstNum = Int32.Parse(Console.ReadLine());
            int secondNum = Int32.Parse(Console.ReadLine());

            if (selection == "1")
            {
                int result = Adder(firstNum, secondNum);
                Console.WriteLine(result);
            }



            Console.ReadLine();
        }

        //Method to add numbers
        static int Adder(int num1, int num2)
        {
            return num1 + num2;
        }

        //Method to subtract numbers
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        //Method to multiply numbers
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        //Method to divide numbers
        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
