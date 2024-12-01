// Create the debugger class using Prorgam.cs as a template.
using System;

namespace microvm
{
    class Debugger
    {
        private bool running;
        public Debugger()
        {
            running = false;
        }
        public void Run()
        {
            running = true;
            while (running)
            {
                Console.Write(">");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "exit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Unknown command");
                        break;
                }
            }
        }
    }
}