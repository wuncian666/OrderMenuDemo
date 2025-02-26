using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 點餐.Discounts
{
    internal class FifteenOffDiscount : Discount
    {
        public override void ImplDiscount(List<Meal> meals)
        {
            foreach (Meal meal in meals)
            {
                meal.Subtotal *= 0.85;
            }
        }
    }
}