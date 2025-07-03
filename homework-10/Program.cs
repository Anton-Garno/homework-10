using System;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eenter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Family name(Surname) ");
            string familyName = Console.ReadLine();
            
            if (name[0] == familyName[0])
            {
                Console.WriteLine("Your name and family name starts with the same letter.");
            }
            else
            {
                Console.WriteLine("Your name and family name do not start with the same letter.");
            }

        }
    }
}

    
    

