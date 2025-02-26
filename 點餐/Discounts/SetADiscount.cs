using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 點餐.Discounts
{
    internal class SetADiscount : Discount
    {
        public override void ImplDiscount(List<Meal> meals)
        {
            Meal chicken1 = meals.FirstOrDefault(x => x.Name == "雞腿飯");
            Meal drink = meals.FirstOrDefault(x => x.Name == "沙士");

            if (chicken1 != null && drink != null)
            {
                int chicken1Count = chicken1.Num;
                int drinkCount = drink.Num;
                int setNum = Math.Min(chicken1Count, drinkCount);
                Order.OrderMeal(new Meal("套餐A-折扣", -10, setNum));
            }
        }
    }
}