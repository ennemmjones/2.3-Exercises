using System;

namespace Exercise28
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitCondition = true;// set initial state of exit condition
            while (exitCondition)
            {

                Console.WriteLine("Enter some text:");
                string inputString = Console.ReadLine(); // read user input
                string noVowels = RemoveVowels(inputString);
                Console.WriteLine(noVowels); // output string with vowels removed

                Console.WriteLine("Would you like to continue (y/n)?"); // prompt user to continue or exit

                if (Console.ReadLine().ToLower() != "y") // user input to continue or exit
                {
                    exitCondition = false; // change condition to exit if user input other than y
                    Console.WriteLine("Goodbye!");
                }
            }
            

        }
        static public string RemoveVowels(string inputString)
        {
            string noVowels = string.Empty;
            string vowels = "aeiouAEIOU"; // define vowels

            foreach (char c in inputString)
            {
                if (vowels.IndexOf(c) == -1) // true when char from user input string is NOT in string vowels
                {
                    noVowels += c.ToString(); // append c to noVowels
                }
            }
            return noVowels;
        }
    }
}
