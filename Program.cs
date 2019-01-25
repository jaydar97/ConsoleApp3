using System;

namespace Iteration_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // question
            Console.Write("Enter an Integer value between 1 and 100: ");
            /*
            try catch block
            */
            try
            {
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 0) && (value_of_input <= 100))
                {
                    // for loop
                    for (int i = 0; i < value_of_input; i++)
                    {
                        Console.WriteLine("You have entered " + value_of_input.ToString() + ". This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                }
                
                // if the user does not enter a value between 1 and 100
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 100 and try again ...");
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    Console.ReadKey(true);
                }
            } // end of try
            catch
            {
                Console.WriteLine("Please enter an integer value and try running the program again ...");
                Console.WriteLine("Press any key to exit the program ...");
                Console.ReadKey(true);
            } // end of catch
        } 
    } 
} 