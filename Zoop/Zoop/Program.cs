using System;

namespace Zoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Cyber-Zoo!");

            Dog dog = new Dog();
            dog.Name = "Hatchiko";
            Console.WriteLine($"i am {dog.Name}");

            Wolf Balto = new Wolf();
            Chicken Little = new Chicken();
            Hawk Killer = new Hawk();
        }
    }
}
