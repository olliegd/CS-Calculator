using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"so... what was it? oh yes.. {name}, What operator would you like to use? - (+, -, *, /, %)");
            var method = Console.ReadLine();
            Console.WriteLine("Enter your first number: ");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your second Number: ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            if (method.Equals("+"))
            {
                Console.WriteLine($"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber}");
            }
            else if(method.Equals("-"))
            {
                Console.WriteLine($"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber}");
            }
            else if (method.Equals("*"))
            {
                Console.WriteLine($"{FirstNumber} x {SecondNumber} = {FirstNumber * SecondNumber}");
            }
            else if (method.Equals("/"))
            {
                Console.WriteLine($"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber}");
            }
            else if (method.Equals("%"))
            {
                Console.WriteLine($"{FirstNumber}% Of {SecondNumber} = {FirstNumber % SecondNumber}");
            }


            Console.WriteLine("Thanks for using this awful Calculator... you may exit!");
        }
    }
}
