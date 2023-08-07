using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public delegate void CouponDelegate(string customerName, double purchaseAmount, ref double couponAmount);

    internal class Delegates
    {
        public void D1(string customerName, double purchaseAmount, ref double couponAmount)
        {
            Console.WriteLine($"{customerName} {purchaseAmount}");

            if (purchaseAmount > 2000)
            {
                couponAmount = purchaseAmount - couponAmount;

                Console.WriteLine($"Purchase amount is {purchaseAmount} and discount with the coupen amount  is {couponAmount}");

            }
        }

        static void Main(string[] args)
        {
            Delegates delegates = new Delegates();

            double couponAmount = 1000;

            CouponDelegate dele = delegates.D1;

            dele("Harita", 100000, ref couponAmount);

            Console.WriteLine($"Coupon Amount: {couponAmount}");

            Console.ReadLine();
        }
    }
}


