﻿using System;
using System.Text;

namespace CSExercises
{
    //The C# language gives facilities for changing cases all to upper or lower - 
    //however, not to title case.  Write a program that would convert a given sentence/phrase to title case.
    //Example
    //“institute of systems science”   =>   “Institute Of System Science”

    public class ExG3
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string newphrase = ToTitleCase(phrase);

            Console.WriteLine(newphrase);
        }

        public static string ToTitleCase(string phrase)
        {  
            string[] wordList = phrase.Split(' ');
            string result=null;

            for (int i = 0; i < wordList.Length; i++)
            {
                for (int j = 0; j < wordList[i].Length; j++)
                {
                    if( j== 0)
                        result += wordList[i].ToCharArray().GetValue(j).ToString().ToUpper();
                    else
                        result += wordList[i].ToCharArray().GetValue(j).ToString().ToLower();
                    

                }
                result += " ";
            }

            return result;


        }
    }
}
