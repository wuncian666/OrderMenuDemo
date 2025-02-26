using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 點餐.Discounts;

namespace 點餐
{
    internal class DiscountHandler
    {
        public DiscountHandler()
        { }

        public static void UseDiscount(List<Meal> meals, string discount)
        {
            ResetMealList(meals);

            if (discount == null)
            {
                ShowPanel.CreateSubtotal(meals);
                return;
            }

            DiscountContext discountContext = new DiscountContext(discount);
            discountContext.ImplDiscount(meals);

            ShowPanel.CreateSubtotal(meals);
        }

        private static void ResetMealList(List<Meal> meals)
        {
            meals.RemoveAll(x => x.Name.Contains("折扣") || x.Name.Contains("贈品"));
            meals.RemoveAll(x => x.Price <= 0 || x.Num == 0);
        }
    }
}