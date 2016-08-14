using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
             Console.Write("Enter distance : ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CalculateFare(distance));
        }

        public static string CalculateFare(double distance)
        {
            return Math.Round(2.40 + distance * 0.4,1).ToString(".00");
        }
    }
}
