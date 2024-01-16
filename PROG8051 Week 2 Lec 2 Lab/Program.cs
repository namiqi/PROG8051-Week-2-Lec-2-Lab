
using System;

namespace CSharpFundamentalsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            // Exercises
            Console.WriteLine("Please enter your first Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your last Name:");
            string lastname = Console.ReadLine();

            string result = $"{name[0]}{lastname}@conestoga.on.ca";
            Console.WriteLine(result.ToLower());

            // To do 
            // Write code to create an email address for students
            // student email address looks like : t.user4526@conestoga.on.ca
            // student id = 12384526 - Substring()


            Console.WriteLine("Welcome to Lab 1");

            // Data Types and Conversions
            int year = 2024;
            string classname = "Prog8051";
            bool finalexam = true;
            double assignment1 = 15.0;
            char highestMark = 'A';

            // Property of a String was the Length of the string
            Console.WriteLine("The string has " + classname.Length + " characters.");
            Console.WriteLine(classname[3]);

            // String Exploration

            Console.WriteLine(classname.ToUpper());
            Console.WriteLine(classname.ToLower());

            Console.WriteLine(classname.StartsWith("Pro"));
            // Reading from and Writing to Console
        }
    }
}