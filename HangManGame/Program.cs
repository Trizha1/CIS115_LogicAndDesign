using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Project_Wk4
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
            char letter;
            int score = 0;
            

            //welcome message
            Console.WriteLine("Welcome to my hangman game, Good Luck!");
            Console.WriteLine("****");
            
            //get input from user
            Console.Write("\n\n Please enter a letter: ");
            letter = char.Parse(Console.ReadLine());

          
            while (letter == letter1 || letter == letter2 || letter == letter3 || letter == letter4)
            {
                Console.WriteLine("You guessed Correctly");              
                Console.Write("Please enter a letter: ");
                letter = char.Parse(Console.ReadLine());

            if (letter != letter1 || letter != letter2 || letter != letter3 || letter != letter4)
                {
                    Console.WriteLine("Sorry you guessed wrong");
                    Console.Write("Please enter a letter: ");
                    letter = char.Parse(Console.ReadLine());

                }
            }
            
           
            Console.ReadLine();//keep console window open
            

        }
    }
}

