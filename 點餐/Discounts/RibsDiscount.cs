using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 點餐.Discounts
{
    internal class RibsDiscount : Discount
    {
        public override void ImplDiscount(List<Meal> meals)
        {
            Meal ribs = meals.FirstOrDefault(x => x.Name == "排骨飯");
            if (ribs != null && ribs.Num > 0)
            {
                Order.OrderMeal(new Meal("贈品-可樂", 0, ribs.Num));
            }
        }
    }
}