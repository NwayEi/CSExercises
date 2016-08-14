using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter x1 coordinates");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter y1 coordinates");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter x2 coordinates");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter y2 coordinates");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(CalculateDistance(x1, y1,x2,y2));
            
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double resultx = x2 - x1;
            double resulty = y2 - y1; 
            
            return Math.Sqrt((resultx * resultx) +(resulty * resulty));
        }
    }
}
