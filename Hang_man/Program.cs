using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hang_man
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Make the base
            string[] words = { "jump", "bachelor", "junior", "programming", "university", "master", "boyfriend", "football" };

            //pick random word
            Random random = new Random();
            int randomnumber = random.Next(0, words.Length + 1);
            string selectedWord = words[randomnumber];
            string hiddenWord = "";
            for (int i = 0; i < selectedWord.Length; i++)
            {
                hiddenWord += "*";
            }
            //Guess
            while (hiddenWord.Contains("*"))
            {
                Console.WriteLine("Word: {0}", hiddenWord);
                Console.Write("Guess a letter! ");
                char letter = char.Parse(Console.ReadLine());
                bool constainsLetter = false;
                for (int i = 0; i < selectedWord.Length; i++)
                {
                    if (letter == selectedWord[i])
                    {

                        hiddenWord = hiddenWord.Remove(i, 1);
                        hiddenWord = hiddenWord.Insert(i, letter.ToString());
                        constainsLetter = true;

                    }

                }
                //Check
                if (constainsLetter == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Yes! {0} is in the word! ", letter);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No :c {0} is NOT in the word! ", letter);
                }
                Console.ResetColor();
            }
        }
    }
}
