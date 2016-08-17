using System;

namespace CSExercises
{
    //The marks obtained by five students in Programming course are as below:
    //  Name        Mark
    //  John	    63
    //  Venkat	    29
    //  Mary	    75
    //  Victor	    82
    //  Betty	    55

    //Write a program that would take store the above information in two arrays(one for Name and one for Marks.The program would then print two reports:

    //c.First report sorted in descending order of the Marks (i.e.student rank)
    //d.Second report sorted on student names alphabetically.

    public class ExG4
    {
        public static void Main(string[] args)
        {
            string[,] studentMarks = new string[5, 2]
           {
               {"John","63"},{"Venkat","29"},
               {"Mary","75"},{"Victor","82"},
               {"Betty","55"}
           };

            PrintByMarks(studentMarks);
           
        }

        public static void PrintByMarks(string[,] studentMarks)
        {
        

            for (int i = 0; i < studentMarks.Length; i++)
            {
                string temp = "";

                for(int j = 1 ; j < studentMarks.Length-1; j++)
                {
                    if (Convert.ToInt32(studentMarks[i, j]) < Convert.ToInt32(studentMarks[j, j]))
                    {
                        
                    }
                }
                



            }
        }
    }
}
