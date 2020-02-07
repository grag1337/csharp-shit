using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Do you want to use the \r\n 1. Calculator or \r\n 2. Eat shit? or \r\n 3. Class shit.");
            string choice1;
            choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                string choice;
                Console.WriteLine("Choose a function: \r\n [+] 1. Addition \r\n [+] 2. Subtraction");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("[-] Enter your first number");
                    double meth = Double.Parse(Console.ReadLine());
                    Console.WriteLine("[-] Enter your second number");
                    double meth2 = Double.Parse(Console.ReadLine());
                    double meth3 = meth2 + meth;
                    Console.WriteLine("[+] Your number is: " + meth3);
                }
                else if (choice == "2")
                {
                    Console.WriteLine("[-] Enter your first number");
                    double meth = Double.Parse(Console.ReadLine());
                    Console.WriteLine("[-] Enter your second number");
                    double meth2 = Double.Parse(Console.ReadLine());
                    double meth3 = meth2 - meth;
                    Console.WriteLine("[+] Your number is: " + meth3);
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Secret Function! Congratulations!");
                    Console.WriteLine("It's not that secret actually.");
                }
                else
                {
                    Console.WriteLine("Invalid Option.");
                }
            }
            else if (choice1 == "2")
            {
                Console.WriteLine("Eat ass, skate fast.");
            }
            else if (choice1 == "abcdefg")
            {
                Console.WriteLine("Wtf, why did you type this?");
                Console.ReadLine();
            }
            else if (choice1 == "3")
            {
                Console.WriteLine("CLass shithishi sihas dkj");
                
            }
            else
            {
                Console.WriteLine("Aight bro");
            }
        }
    }
}
