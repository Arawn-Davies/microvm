// Write a basic C# template for a console application.
using System;

namespace microvm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CPU cpu = new CPU(new Memory(1024));
            cpu.Run();

        }
    }
}