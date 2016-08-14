using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {

            Console.Write("Enter distance : ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CalculateFare(distance));
        }

        public static string CalculateFare(double distance)
        {
            double result = Math.Ceiling((2.40 + distance * 0.4) * 10) / 10;
            return result.ToString(".00");

        }
    }
}
