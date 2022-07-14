using System;

namespace Net_5
{
    class Program
    {

        //fields, constants are fields.
        const double PI = 3.14159265359;
        const int Weeks = 52;
        const int Months = 12;
        const int Days = 365;
        const string Birthday = "31.05.1988";

        static void Main(string[] args)
        {
            //string input;
            //Console.WriteLine("Pleace enter your name and press enter : ");
            //input = Console.ReadLine();
            //Console.WriteLine(input);

            //Console.WriteLine("Enter a string here : ");
            //Console.WriteLine("Enter a character to search : ");
            //char charInput = Console.ReadLine()[0];//read the character from the string
            //int index = input.IndexOf(charInput);//gets the index of he character from string
            //Console.WriteLine("Index of character {0} in string is {1}", charInput, index);

            //WriteSomeText("Hello!");

            //Console.WriteLine(Add(1, 2));

            //string userInput = Console.ReadLine();

            //Console.WriteLine(userInput);

            //Console.Read();

            //try-catch example

            Console.WriteLine("Enter a number: ");

            string newUserInput = Console.ReadLine();

            try
            {
                int inputAsUser = int.Parse(newUserInput);//try to execute the code, like an if statement
            }
            catch (FormatException)
            {

                Console.WriteLine("Format exception, enter only numbers!");//if the code doesn't work.
            }
            catch (OverflowException)
            {
                Console.WriteLine("General exception! The number is too long or too short for an int32.");
            }
            finally
            {
                Console.WriteLine("This is called anyways.");//just like else statement in if-else
            }

            Console.ReadKey();

        }

        //access modifier(static) return type(void) method name (parameters) when we wanna call static method, we must call it in statc method
        //methods used to do only one thing
        static public void WriteSomeText(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }

        public static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
    }
}
