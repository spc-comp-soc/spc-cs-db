using System;

namespace Program
{
    class Program
    {
        static string Info(string name, int age, string gender)
        {
            return $"Your name is {name}.\nYou are {age} years old.\nYou are {gender}.";
        }

        static string Greeting() => "Hello"; //Expression operator: return the value

        static void Main(string[] args)
        {
            string Charles = Info("Charles", 98, "Male");

            Console.WriteLine(Greeting() + ", the information of Charles is:\n" + Charles);

            Console.ReadLine();
        }
    }
}