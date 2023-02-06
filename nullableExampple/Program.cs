using System;

namespace nullableExampple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a nullable integer variable named x
            int? x = null;

            // Check if x has a value assigned to it
            if (x.HasValue)
            {
                // If x has a value, print it
                Console.WriteLine("x has a value of: " + x.Value);
            }
            else
            {
                // If x is null, print a message indicating it's null
                Console.WriteLine("x is null");
            }
        }
    }
}