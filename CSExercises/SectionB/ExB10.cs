using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.


        public static void Main(string[] args)
        {
            Console.Write("Please enter side a : ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter side b : ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Please enter side c : ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Write(CalculateArea(a, b, c));


        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s*((s - a)*(s - b)*(s - c)));
        }
    }
}