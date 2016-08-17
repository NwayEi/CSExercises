using System;


namespace CSExercises.SectionQuiz
{
    class Quizz5
    {
        public static void Main(string[] args)
        {
            int[,] theArray = new int[,]
           {
               {5,3},{2,9},{2,9},{5,1},{7,1},{8,3},{0,3},{2,2},{9,7}

           };

            int count = 0;

            Console.Write("Please enter a number (0-9) : ");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (theArray[i, j] == input)
                        count += 1;

                }
            }

            Console.WriteLine("The number of {0} is {1}", input, count);
        }
    }
}
