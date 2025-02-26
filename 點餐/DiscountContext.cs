using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 點餐.Discounts;

namespace 點餐
{
    internal class DiscountContext
    {
        private Discount implDiscount = null;

        public DiscountContext(String discount)
        {
            implDiscount = DiscountFactory.create(discount);
        }

        public void ImplDiscount(List<Meal> meals)
        {
            ResetMealList(meals);
            implDiscount.ImplDiscount(meals);
            ShowPanel.CreateSubtotal(meals);
        }

        private void ResetMealList(List<Meal> meals)
        {
            meals.RemoveAll(x => x.Name.Contains("折扣") || x.Name.Contains("贈品"));
            meals.RemoveAll(x => x.Price <= 0 || x.Num == 0);
        }
    }
}