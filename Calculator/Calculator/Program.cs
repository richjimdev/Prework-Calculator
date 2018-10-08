using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Putting code in loop to allow the use of multiple calculator methods
            while(1 > 0)
            {
                //Guiding user on how to use this calculator app
                Console.WriteLine("What calculator function would you like to perform?");
                Console.WriteLine(@"1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("Type 'quit' to exit.");

                //Saving user selection into a variable
                string selection = Console.ReadLine();

                if (selection == "quit") //If user wants to quit, this breaks the loop
                    break;

                //saving two user submitted numbers to calculate the result
                Console.WriteLine("Input two numbers to calculate your final result:");
                Console.Write("First number: ");
                int firstNum = Int32.Parse(Console.ReadLine());
                Console.Write("Second number: ");
                int secondNum = Int32.Parse(Console.ReadLine());

                //calculating result based on selected method and number inputs
                int result = 0;
                Console.Write("Your result is: ");

                if (selection == "1")
                    result = Adder(firstNum, secondNum);
                if (selection == "2")
                    result = Subtract(firstNum, secondNum);
                if (selection == "3")
                    result = Multiply(firstNum, secondNum);
                if (selection == "4")
                    result = Divide(firstNum, secondNum);

                Console.WriteLine(result); //finally, display result
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

