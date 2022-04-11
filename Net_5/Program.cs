using System;

namespace Net_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Pleace enter your name and press enter : ");
            input = Console.ReadLine();
            Console.WriteLine(input);

            Console.WriteLine("Enter a string here : ");
            Console.WriteLine("Enter a character to search : ");
            char charInput = Console.ReadLine()[0];//read the character from the string
            int index = input.IndexOf(charInput);//gets the index of he character from string
            Console.WriteLine("Index of character {0} in string is {1}", charInput, index);
        }
    }
}
