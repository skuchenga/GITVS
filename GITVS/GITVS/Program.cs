using System;

namespace GITVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Edited from github web");
        }
        private static int GenerateRandom()
        {
            return new Random().Next(5, 30);

        }
    }
}
