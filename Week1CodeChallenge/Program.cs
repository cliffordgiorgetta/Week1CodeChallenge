using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {  // Do FizzBuzz Loop 1=>20
            // Call FizzBuzz() for each number in the loop
            // End FizzBuzzLoop 1=>20
            for (var i = 1; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            // Do FizzBuzz Loop 92=>79
            // Call FizzBuzz() for each number in the loop
            // End FizzBuzzLoop 92=>79
            for (var i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }
            //Call Yodaizer Function with the text "I like code"

            //Call TextStats Function with the text "Coding is super fun and useful.  This function requires the use of 
            //arrays, loops, indexes, and if statements. There was a lot of thought that went into this code."            
            TextStats("Coding is super fun and useful");
            //Call IsPrime Function
            // Do IsPrime Loop 1=>25
            // Call IsPrime() for each number in the loop
            // End IsPrime Loop 1=>25

            //Call DashInsert Function with the number 8675309

            //Console.ReadKey() to keep the console window open until we close it.
            Console.ReadKey();
        }
        //FizzBuzz Function
        static void FizzBuzz(int number)
        {
            //To Do: Fill in FizzBuzz Logic
            //if divisable by both 5 & 3, print fizzbuzz
            //if divisable by 5, print fizz
            //if divisable by 3, print buzz
            //if divisable by neither, print the number
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine("number");
            }
        }
        //Yodaizer
        static void Yodaizer(string textytext)
        {
            Yodaizer("i like code");

            //To Do: Fill in Yodaizer Logic

            // print out the words of text in reverse order
            // "i like code" => "code like i"
            // use .Split to seperate words in the string
            string[] array = textytext.Split(' ');

            // use a for loop to print the words in reverse order
            for (var i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + ' ');
            }
        }
        //Text Stats
        static void TextStats(string input)
        {
            //To Do: Fill in Text Stats Logic
            // process a string to print out the following:
            // print out the # of characters
            Console.WriteLine("# of characters: " + input.Length);
            // print out the # of words
            string[] array = input.Split(' ');
            Console.WriteLine("# of words: " + input.Split(' ').Length);
            // print out the # vowels
            Console.WriteLine("# of Vowels: " + vowels);

            //loop through each character and see if its a vowel, consanant, or special character, and then add to a counter
            Console.WriteLine("# of consanants: " + consanants);
            Console.WriteLine("# of specialChars: " + specialChars);
            var vowel = 0; var consonants = 0; var specialChars = 0;
            for (var i = 0; i < input.Length; i++)
            {
                var c = input[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
                {
                    vowels += 1;
                }
                else if (c == "." || c == "," || c == "!" || c == "?" || c == " ")
                {
                    specialChars += 1;
                }
                else
                {
                    consanants += 1;
                }
            }
            // print out the # consonants
            // print out the # of special characters
        }
        //IsPrime
        static void IsPrime(int number)
        {
            //To Do: Fill in IsPrime Logic
            var divisibleCount = 0;
            for (var i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisibleCount += 1;
                }
            }
            if (divisibleCount == 2)
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number);
            }
            //if # is a prime, write "X is a prime number
            //if # is not prime, just print out the #
            // prime numbers are numbers that are only divisible by 1 and itself
        }
        //DashInsert
        static void DashInsert(int number)
        {
            //To Do: Fill in DashInsert Logic
        }

    }
}
