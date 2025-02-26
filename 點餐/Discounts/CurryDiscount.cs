using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 點餐.Discounts
{
    internal class CurryDiscount : Discount
    {
        public override void ImplDiscount(List<Meal> meals)
        {
            Meal curry = meals.FirstOrDefault(x => x.Name == "咖哩飯");
            if (curry != null && curry.Num >= 2)
            {
                int numFreeCurry = curry.Num / 2;
                Order.OrderMeal(new Meal("贈品-咖哩飯", 0, numFreeCurry));
            }
        }
    }
}