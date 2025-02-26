using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 點餐.Discounts
{
    internal class TripleChickenDiscount : Discount
    {
        public override void ImplDiscount(List<Meal> meals)
        {
            Meal chicken = meals.FirstOrDefault(x => x.Name == "雞腿飯");
            if (chicken != null && chicken.Num >= 3)
            {
                int num = chicken.Num / 3;
                Order.OrderMeal(new Meal("折扣-雞腿飯", -30, num));
            }
        }
    }
}