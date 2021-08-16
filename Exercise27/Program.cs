using System;

namespace Exercise27
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exitCondition = true;// set initial state of exit condition
            while (exitCondition)
            {

                Console.WriteLine("Enter some text:");
                string inputString = Console.ReadLine().ToLower(); // read user input
                int consonantCount = ConsonantCounter(inputString);
                
                Console.WriteLine(consonantCount);

                Console.WriteLine("Would you like to continue (y/n)?"); // prompt user to continue or exit

                if (Console.ReadLine().ToLower() != "y") // user input to continue or exit
                {
                    exitCondition = false; // change condition to exit if user input other than y
                    Console.WriteLine("Goodbye!");
                }
            }
        }
        static public int ConsonantCounter(string inputString)
        {
            string consonants = "bcdfghjklmnpqrstvwxyz"; // define consonants
            int consonantCount = 0;  // set initial state of count


            foreach (char c in inputString)
            {
                foreach (char n in consonants) // iterate over each consonant n for every char c in inputString
                {
                    if (n == c)
                    {
                        consonantCount++;  // increase vowel count if charcter matches
                    }
                }
            }
            return consonantCount;
        }
    }
}