using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guide the user...
            Console.WriteLine( "Please enter add/subtract/multiply/exit:" );

            // Collect the user input...
            string userInput;
            while ( ( userInput = Console.ReadLine() ) != "exit" ) // LOOPS until a user enters "exit" command.
            {
                
                // Switch statements are similar to if/else.
                switch ( userInput ) // Here we enter the value we want to test.
                { // Cases are us testing the above against specific values.
                    case "add":
                        Console.WriteLine( "Enter first number for addition:" );
                        int firstNum = Int32.Parse( Console.ReadLine() );
                        Console.WriteLine( "Enter second number for addition:" );
                        int secondNum = Int32.Parse( Console.ReadLine() );
                        int result = firstNum + secondNum;
                        Console.WriteLine( "{0} + {1} = {2}", firstNum, secondNum, result );
                        break;
                    case "subtract":
                        Console.WriteLine( "Enter first number for subtraction:" );
                        int firstNum = Int32.Parse( Console.ReadLine() );
                        Console.WriteLine( "Enter second number for subtraction:" );
                        int secondNum = Int32.Parse( Console.ReadLine() );
                        int result = firstNum - secondNum;
                        Console.WriteLine( "{0} - {1} = {2}", firstNum, secondNum, result );
                        break;
                    case "multiply":
                        Console.WriteLine( "Enter first number for multiply:" );
                        int firstNum = Int32.Parse( Console.ReadLine() );
                        Console.WriteLine( "Enter second number for multiply:" );
                        int secondNum = Int32.Parse( Console.ReadLine() );
                        int result = firstNum * secondNum;
                        Console.WriteLine( "{0} * {1} = {2}", firstNum, secondNum, result );
                        break;
                    default:
                        Console.WriteLine( "Unrecognized operator/command entered." );
                        break;
                } // End of switch statement.
                Console.WriteLine( "Please enter a new command: add/subtract/multiply/exit." );
            } // End of while statement.
        }
    }
}
