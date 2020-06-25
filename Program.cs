﻿using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // "=" is the assignment operator!
            // String datatype is used for text.
            string myString = "This is a string!";
            // Integer datatype is used for whole numbers (no decimals.)
            int myInt = 42;
            // Double datatype is used for decimal point numbers.
            double myDouble = 33.666;
            // Boolean datatype is used for TRUE/FALSE values - think binary!
            bool myBool = true;

            // Subtraction operator is "-" (minus.)
            Console.WriteLine( myInt - 10 ); // 32

            // Multiplication operator is "*" (multiply.)
            Console.WriteLine( myInt * 2 ); // 84

            // Division operator is "/" (division.)
            Console.WriteLine( myInt / 2 ); // 21

            // Modulus operator is "%" (percent sign.)
            Console.WriteLine( myInt % 13 ); // 3

            // Addition operator is "+" (plus.)
            // ***WAIT! This is ALSO the concatenation operator.
            Console.WriteLine( myInt + 8 ); // 50

            Console.WriteLine( "3" + "3" ); // 33

            Console.WriteLine( "3" + 3 ); // 33
            Console.WriteLine( 3 + 6 + "3" ); // 93
        }
    }
}
