using System;

namespace c_sharp_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 dimensional array!
            string[,] topics = {{"cat","dog","frog","hedgehog"},
                                {"zebra","giraffe","lion","elephant"},
                                {"dolphin","octopus","shark","whale"}};
            // We can use a foreach to iterate through the list of lists, one list at a time.
            foreach( string topic in topics )
            {
                // Output the current animal!
                Console.WriteLine( "This animal is: {0}", topic );
            }
        }
    }
}
