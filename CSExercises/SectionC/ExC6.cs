using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE - get user input, call the function and return the discounted price
            Console.Write("Please enter order quantity for TV : ");
            int order_TV = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter order quantity for DVD : ");
            int order_DVD = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter order quantity for DVD : ");
            int order_MP3= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(CalculateTotalPrice(order_TV, order_DVD, order_MP3));

            Console.ReadLine();
        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            int totalPrice_TV = tvQty * 900;
            int totalPrice_DVD = dvdQty * 500;
            int totalPrice_MP3 = mp3Qty * 700;

            int total_amount = totalPrice_TV + totalPrice_DVD + totalPrice_MP3;

            if (total_amount > 10000) 
            {
                int TV_DiscountPrice =Convert.ToInt32(0.15 * totalPrice_TV);
                int DVD_DiscountPrice = Convert.ToInt32(0.15 * totalPrice_DVD);

                total_amount -= (TV_DiscountPrice + DVD_DiscountPrice);

            }

            else if (total_amount > 5000)
            {
                int TV_DiscountPrice = Convert.ToInt32(0.1 * totalPrice_TV);
                int DVD_DiscountPrice = Convert.ToInt32(0.1 * totalPrice_DVD);

                total_amount -= (TV_DiscountPrice + DVD_DiscountPrice);
            }
            return total_amount;

        }
    }
}