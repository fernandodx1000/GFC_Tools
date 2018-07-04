using System;
using System.Threading;

namespace GFC_Tools
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(Start);
            thread.Start();

            Console.WriteLine("Starting!");
            while (true) // Loop indefinitely
            {
                Console.WriteLine("Enter input:"); // Prompt
                string line = Console.ReadLine(); // Get string from user
                if (line == "exit") // Check string
                {
                    break;
                }
                if (line == "test")
                {
                    Start();
                }


                switch (line)
                {
                    case "/help":
                        Console.WriteLine("This should be help.");
                        break;

                    case "/version":
                        Console.WriteLine("This should be version.");
                        break;
                    case "/quit":
                        break;

                    default:
                        Console.WriteLine("Unknown Command " + line);
                        break;
                }


            }

            void Start()
            {
                var startup = new StartUp();
                startup.Main();


            }

        }
    }
}
