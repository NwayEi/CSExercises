using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises.SectionQuiz
{
    class Quizz6
    {
        static int[] minIncomeArray = new int[]
                { 20000, 30000,40000,80000,
                  120000,160000,200000,320000};
        static double[] taxRateArray = new double[] { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };

        static int[] basePayableAmountArray = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };

        static void Main(string[] args)
        {
            int annualIncome = 
        }

        public static int AskforIncome()
        {
            Console.Write("Please enter your annual taxable income: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int GetTaxBracket(int income)
        {
            int largetst = 0;

            for(int i=0;i<minIncomeArray.Length;i++)
        }
    }
}
