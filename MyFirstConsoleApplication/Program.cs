using System;

namespace MyFirstConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input from a user
            Console.WriteLine("What is your first name?");
            var input = Console.ReadLine();

            //strings
            string name = "Joseph";
            char firstLetter = 'J';

            var myInterpolatedString = $"My name is {input} and the " +
                $"first letter of my name is {firstLetter}";
            var stringLiteral = @"This is a paragraph.
                                  It is across multiple lines.
                                  Returns will be honored in the output.";
            Console.WriteLine(myInterpolatedString);
            Console.WriteLine(stringLiteral);

            //Number Types
            int number = Int32.MaxValue;

            long bigNumber = Int64.MaxValue;

            short littleNumber = Int16.MaxValue;

            Console.WriteLine(number);
            Console.WriteLine(bigNumber);
            Console.WriteLine(littleNumber);

            //decimals can be represented by [f]loat(32bit) [d]ouble(64bit) or deci[m]al(128bit)
            var addition = 1 + 1.1d;
            var division = 3 / 2d;
            

            var implicitStringThing = "This is an implicitly typed variable.";

            Console.WriteLine(implicitStringThing);

            var today = DateTime.Today;

            //instantiation
            var bestYear = new DateTime(2020,1,1);

            // anonymous type, new object
            var person = new { Name = "Joseph" };

            //everything either is or can be an object
            //an object can literally store anything
            object weirdStuff = 1234;
            weirdStuff = "More craziness";


            Console.WriteLine(weirdStuff);

            //arrays
            var names = new string[5];

            var secondName = names[1];
            names[1] = "Jimmy";

            //array intializer
            var colors = new string[] { "white", "blue", "black", "yellow", "teal", "magenta" };

            //control flow
            //if else
            if (input == "Joseph")
            {
                Console.WriteLine("Duh");
            }
            else if (input == "blerg")
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("Not Joseph");
            }
            //for loop
            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine($"currently for looping on color {colors[i]}");
            }
            //while loop
            var counter = 1;
            while (true)
            {
                Console.WriteLine($"While loop iteration {counter}.");

                if (counter <= 5)
                {
                    counter++;
                    continue;
                }

                break;
            }
            //foreach
            foreach (var color in colors)
            {
                Console.WriteLine($"Foreach looping on color {color}");
            }

        }
    }
}
