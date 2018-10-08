using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while(1 > 0)
            {
                Console.WriteLine("What calculator function would you like to perform?");
                Console.WriteLine(@"1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("Type 'quit' to exit.");

                string selection = Console.ReadLine();

                if (selection == "quit")
                {
                    break;
                }

                Console.WriteLine("Input two numbers to calculate your final result:");
                Console.Write("First number: ");
                int firstNum = Int32.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                int secondNum = Int32.Parse(Console.ReadLine());

                Console.Write("Your result is: ");

                if (selection == "1")
                {
                    int result = Adder(firstNum, secondNum);
                    Console.WriteLine(result);
                }
                if (selection == "2")
                {
                    int result = Subtract(firstNum, secondNum);
                    Console.WriteLine(result);
                }
                if (selection == "3")
                {
                    int result = Multiply(firstNum, secondNum);
                    Console.WriteLine(result);
                }
                if (selection == "4")
                {
                    int result = Divide(firstNum, secondNum);
                    Console.WriteLine(result);
                }

            }
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
