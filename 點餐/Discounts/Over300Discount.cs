using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 點餐.Discounts
{
    internal class Over300Discount : Discount
    {
        public override void ImplDiscount(List<Meal> meals)
        {
            if (Order.GetAmount() > 300)
            {
                int discount50Num = Order.GetAmount() / 300;
                Order.OrderMeal(new Meal("消費300折扣50", -50, discount50Num));
            }
        }
    }
}