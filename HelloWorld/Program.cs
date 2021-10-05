using System;

namespace HelloWorld
{
    /// <summary>
    /// created program for testing helloworld program
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fellowship!");
            Addition();
            Console.ReadLine();
        }
        
        public static void Addition()
        {
            Console.WriteLine("Addition operation");
            Console.WriteLine("Modifying in remote master");

            Console.WriteLine("Creating Conflict At Local");

            Console.WriteLine("Creating Conflict At Line Number 21");

        }
    }
}
