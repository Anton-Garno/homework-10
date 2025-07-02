using System;
using System.Text;

namespace Homework10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some words (like this, like some words) :");
            string input = Console.ReadLine()??" ";

            StringBuilder myStringInput = new StringBuilder(input);

            myStringInput.Replace(" ", "");
            Console.WriteLine("Your input without spaces is: " + myStringInput.ToString());




        }
    }
}


