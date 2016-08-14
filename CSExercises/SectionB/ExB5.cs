using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a value of x : ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(CalculateY(x));
            
        }

        public static double CalculateY(double x)
        {            
            return 2 * Math.Pow(x, 2) - (4 * x) + 3;
        }
    } 
}
