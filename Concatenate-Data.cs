using System;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string firstName = Console.ReadLine();


                string lastName = Console.ReadLine();


                byte age = byte.Parse(Console.ReadLine());


                string town = Console.ReadLine();

                Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.",
                    firstName, lastName, age, town);
            }
            catch (Exception)
            {
                Console.WriteLine("You have enter an illegal format variable," +
                    "please enter a legal format variable");
            }
        }
    }
}