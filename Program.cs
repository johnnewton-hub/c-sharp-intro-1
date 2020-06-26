using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user.
            Console.WriteLine( "Please type: (add/subtract/exit)" );
            string command; // Declare a variable.
            // Accept commands.
            while( ( command = Console.ReadLine() ) != "exit" )
            {
                int result;
                if ( command == "add" )
                {
                    Console.WriteLine( "Enter first number to add:" );
                    int firstNum = int.Parse( Console.ReadLine() );
                    Console.WriteLine( "Enter second number to add:" );
                    int secondNum = int.Parse( Console.ReadLine() );
                    result = Addition( firstNum, secondNum );
                    Console.WriteLine( "The result is: {0}", result );
                }
                else if ( command == "subtract" )
                {
                    Console.WriteLine( "Enter first number to subtract:" );
                    int firstNum = int.Parse( Console.ReadLine() );
                    Console.WriteLine( "Enter second number to subtract:" );
                    int secondNum = int.Parse( Console.ReadLine() );
                    result = Subtraction( firstNum, secondNum );
                    Console.WriteLine( "The result is: {0}", result );
                }
                else
                {
                    Console.WriteLine( "Invalid command, please try again." );
                }
                Console.WriteLine( "Please enter a command: (add/subtract/exit)" );
            } // End of the while loop.
        }

        static int Addition( int num1, int num2 )
        {
            return num1 + num2;
        }

        static int Subtraction( int num1, int num2 )
        {
            return num1 - num2;
        }
    }
}
