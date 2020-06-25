using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // Always tell the user what they can do, and guide them!
            Console.WriteLine( "Please tell us if you want to add, subtract, or multiply: (add/subtract/multiply)" );
            string userOperator = Console.ReadLine();

            // Check if the user typed: add
            if ( userOperator == "add" )
            {
                Console.WriteLine( "Please enter the first number:" );
                // @link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                int firstNum = Int32.Parse( Console.ReadLine() ); // Convert to integer.
                Console.WriteLine( "Please enter the second number to add:" );
                int secondNum = Int32.Parse( Console.ReadLine() );
                // Calculate the result.
                int result = firstNum + secondNum;
                Console.WriteLine( "{0} + {1} = {2}", firstNum, secondNum, result );
            }
            else if ( userOperator == "subtract" )
            {
                Console.WriteLine( "Please enter the first number:" );
                // @link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                int firstNum = Int32.Parse( Console.ReadLine() ); // Convert to integer.
                Console.WriteLine( "Please enter the second number to subtract:" );
                int secondNum = Int32.Parse( Console.ReadLine() );
                // Calculate the result.
                int result = firstNum - secondNum;
                Console.WriteLine( "{0} - {1} = {2}", firstNum, secondNum, result );
            }
            else if ( userOperator == "multiply" )
            {
                Console.WriteLine( "Please enter the first number:" );
                // @link https://stackoverflow.com/questions/1019793/how-can-i-convert-string-to-int
                int firstNum = Int32.Parse( Console.ReadLine() ); // Convert to integer.
                Console.WriteLine( "Please enter the second number to multiply:" );
                int secondNum = Int32.Parse( Console.ReadLine() );
                // Calculate the result.
                int result = firstNum * secondNum;
                Console.WriteLine( "{0} * {1} = {2}", firstNum, secondNum, result );
            }
            else
            {
                Console.WriteLine( "Invalid operator entered." );
            }
        }
    }
}
