using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 3;
            // int b = 6;
            // int c = a + b;
            // Console.WriteLine(c);
            // Console.ReadKey();

            //Declare variables and start at zero
            double num1 = 0;
            double num2 = 36;

            //Display title of app
            Console.WriteLine("Calculator Application\r");
            Console.WriteLine("**********************\n");

            //Ask User to input first number
            Console.WriteLine("Please enter a number and press enter:");
            num1 = Convert.ToDouble(Console.ReadLine());

            //Ask user to enter a second number
            Console.WriteLine("Please enter a second number and press enter.");
            num2 = Convert.ToDouble(Console.ReadLine());

            //Ask the user to choose an option. 
            Console.WriteLine("Please choose your operator:");
            Console.WriteLine("\tadd - Add");
            Console.WriteLine("\tsub - Subtract");
            Console.WriteLine("\tdiv - Divide");
            Console.WriteLine("\tmul - Multiply");
            Console.WriteLine("\tstory - I will tell you a story!");

            //Use a switch statement to go through the options
            switch (Console.ReadLine())
            {
                case "add":
                    Console.WriteLine($"Result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "sub":
                    Console.WriteLine($"Result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "div":
                    // Check that the user did not enter 0
                    while (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("Error. Cannot perform division with zero number.");
                        Console.WriteLine("Please enter a number other than zero.");
                        if (num1 == 0)
                        {
                            num1 = Convert.ToDouble(Console.ReadLine());
                        }
                        else
                        {
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    Console.WriteLine($"Result: {num1} / {num2} = " + (num1 / num2));
                    break;
                case "mul":
                    Console.WriteLine($"Result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "story":
                    Console.WriteLine("Have a nice day!!");
                    break;
            }

            //Wait for response
            Console.Write("Press any key to close the application.");
            Console.ReadKey();
        }
    }
}
