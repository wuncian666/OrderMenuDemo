using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 點餐
{
    internal class Order
    {
        private static List<Meal> Meals { get; set; } = new List<Meal>();

        public Order()
        {
        }

        public EventHandler<FlowLayoutPanel> RegistEvent
        {
            get
            {
                return OrderHandler.Regist();
            }
            set
            {
                OrderHandler.handler += value;
            }
        }

        public static void AddOrder(Meal meal, string discount)
        {
            OrderMeal(meal);

            DiscountContext discountContext = new DiscountContext(discount);
            discountContext.ImplDiscount(Meals);
        }

        public static void OrderMeal(Meal newMeal)
        {
            if (newMeal == null)
                return;

            Meal original = Meals.FirstOrDefault(x => x.Name == newMeal.Name);

            if (original == null)
            {
                Meals.Add(newMeal);
                return;
            }

            if (original.Num == 0)
            {
                Meals.Remove(original);
            }
            else
            {
                original.Num = newMeal.Num;
                original.Subtotal = newMeal.Subtotal;
            }
        }

        public static int GetAmount()
        {
            int amount = 0;
            for (int i = 0; i < Meals.Count; i++)
            {
                amount += Meals[i].Num * Meals[i].Price;
            }
            return amount;
        }

        public static void ResetOrder()
        {
            Meals.Clear();
        }
    }
}