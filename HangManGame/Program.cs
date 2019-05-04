using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project_Wk5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Last name = the word used
            char letter1 = 'C';
            char letter2 = 'R';
            char letter3 = 'U';
            char letter4 = 'Z';
            char letter = 'A';
            char[] guessed = new char[10];
            int score = 0;
            


            //welcome message
            Console.WriteLine("Welcome to my Hangman game, Good Luck!");
            Console.WriteLine("CAPITAL LETTERS ONLY");           

            Console.WriteLine("****");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please enter a letter: ");
                letter = char.Parse(Console.ReadLine());

                if (letter == letter1 || letter == letter2 || letter == letter3 || letter == letter4)
                {
                    Console.WriteLine("You guessed correctly!");
                    score--;
                 
                }
                else
                {
                    Console.WriteLine("You guessed incorrectly!");
                    score++;
                }
              
            }

            Console.WriteLine("Your total score is: " + score);

            Console.ReadLine();
        }
    }
}