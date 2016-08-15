using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter three digit number : ");
            int digit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsArmstrongNumber(digit).ToString());
            Console.ReadLine();

        }


        public static bool IsArmstrongNumber(int n)
        {
            int single_digit =Convert.ToInt32( n.ToString().Substring(0, 1));
            int single_digit2 = Convert.ToInt32(n.ToString().Substring(1, 1));
            int single_digit3 = Convert.ToInt32(n.ToString().Substring(2, 1));

            int result = Convert.ToInt32(Math.Pow(single_digit, 3) + Math.Pow(single_digit2, 3) + Math.Pow(single_digit3, 3));

            if (result == n)
                return true;
            else
                return false;
           

        }
    }
}