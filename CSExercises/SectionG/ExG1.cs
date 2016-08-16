using System;
using System.Linq;

namespace CSExercises
{
    //Program to count the number of vowels in a given phrase and print out 
    //the number of each vowel. (a, e, i, o & u are vowels)
    //a.Write a program to read a phrase from the console and count the number 
    //of vowels there are in the phrase.You should substring one character at a time and 
    //match it to the vowels and increment the counter.
    //b.Make your program explicitly count the number of occurrences of each vowel 
    //ie: number of a’s, number of e’s etc.)

    public class ExG1
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            Console.WriteLine("Total number of vowels: " + CountVowels(phrase));

            int[] vowelCount = CountIndividualVowels(phrase);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number of {0}: {1}", vowels[i], vowelCount[i]);
            }
        }

        public static int CountVowels(string phrase)
        {
            int vowelcount=0;

            for(int i=0;i<phrase.Length;i++)
            {
               switch(phrase.Substring(i,1).ToUpper())
               {
                   case "A":
                       vowelcount+=1;break;
                   case "E":
                       vowelcount+=1;break;
                   case "I":
                       vowelcount+=1;break;
                   case "O":
                       vowelcount+=1;break;
                   case "U":
                       vowelcount+=1;break;
                   default:
                       break;
               }
                  

            }
            
            return vowelcount;


        }

        public static int[] CountIndividualVowels(string phrase)
        {
            int[] vowelCount = new int[5];

            for (int i = 0; i < phrase.Length; i++)
            {
                switch (phrase.Substring(i, 1).ToUpper())
                {
                    case "A":
                        vowelCount[0] += 1; break;
                    case "E":
                        vowelCount[1] += 1; break;
                    case "I":
                        vowelCount[2] += 1; break;
                    case "O":
                        vowelCount[3] += 1; break;
                    case "U":
                        vowelCount[4] += 1; break;
                    default:
                        break;
                }


            }
            


            return vowelCount;
        }
    }
}
