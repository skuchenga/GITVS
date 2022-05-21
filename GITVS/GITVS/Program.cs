using System;

namespace GITVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Edited from github web");
            Console.WriteLine(CommonHelper.GetBaseDirectory());
        }
        private static int GenerateRandom()
        {
            return new Random().Next(5, 30);

        }
    }
}
