using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Employee Salary : ");
            String salary = Console.ReadLine();
                  
           Console.WriteLine(CalculateIncome(salary));                                

            
        }

        public static string CalculateIncome(string salaryStr)
        {
            double salary = Convert.ToDouble(salaryStr);
            string calculated_salary="$";
            if (salary > 0)
                calculated_salary += (salary + (0.1 * salary) + (0.03 * salary)).ToString();
            else
                calculated_salary += "0.00";

            return calculated_salary;
        }
    }
}
