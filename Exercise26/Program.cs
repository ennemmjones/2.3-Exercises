using System;

namespace Exercise26
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
                int vowelCount = VowelCounter(inputString);
            
                Console.WriteLine(vowelCount); // output vowel count

                Console.WriteLine("Would you like to continue (y/n)?"); // prompt user to continue or exit

                if (Console.ReadLine().ToLower() != "y") // user input to continue or exit
                {
                    exitCondition = false; // change condition to exit if user input other than y
                    Console.WriteLine("Goodbye!");
                }
            }
        }
        static public int VowelCounter(string inputString)
        {
            string vowels = "aeiou"; // define vowels
            int vowelCount = 0;  // set initial state of count


            foreach (char c in inputString)
            {
                foreach (char v in vowels) // iterate over each vowel v for every char c in inputString
                {
                    if (v == c)
                    {
                        vowelCount++;  // increase vowel count if charcter matches
                    }
                }
            }
            return vowelCount;
        }
    }
}
