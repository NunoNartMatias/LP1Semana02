using System;

namespace ManipularVar
{
    public class Program
    {   
        // Main Method
        static void Main(string[] args)

        {
            // Declaring our variables

            int x = 4, z = 2;
            int y, a;

            // Operation for ++

            y = x++ + z++; // x = 5 | z = 2 | y = 6   

            // Operation for --
            a = --z + --x; // z = 1 | x = 4 | y = 5

            // Printing First Result
            Console.WriteLine("Result is " + y);

            // Printing Second Result
            Console.WriteLine("Result is " + a); 


        }
    }
}
