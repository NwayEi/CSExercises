using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter double precision number : ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(SQRT(input));
        }

        public static double SQRT(double x)
        {
            
            return Math.Sqrt(x);

        }
    }
}
