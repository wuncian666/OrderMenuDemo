using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace 點餐
{
    internal class ShowPanel
    {
        public ShowPanel()
        { }

        public static void CreateSubtotal(List<Meal> meals)
        {
            FlowLayoutPanel packagePanel = new FlowLayoutPanel()
            {
                Height = 600,
            };

            FlowLayoutPanel title = SubtotalContent("品名", "單價", "數量", "小計");
            packagePanel.Controls.Add(title);

            foreach (Meal meal in meals)
            {
                FlowLayoutPanel subPanel = SubtotalContent(
                    meal.Name,
                    meal.Price.ToString(),
                    meal.Num.ToString(),
                    meal.Subtotal.ToString());

                packagePanel.Controls.Add(subPanel);
            }

            OrderHandler.Notify(packagePanel);
        }

        private static FlowLayoutPanel SubtotalContent(string name, string price, string num, string subtotal)
        {
            FlowLayoutPanel subPanel1 = new FlowLayoutPanel()
            {
                Height = 16
            };
            Label Name = new Label()
            {
                Text = name,
                Width = 70,
            };
            Label Price = new Label()
            {
                Text = price,
                Width = 30,
            };
            Label Num = new Label()
            {
                Text = num,
                Width = 30,
            };
            Label Subtotal = new Label()
            {
                Text = subtotal,
                Width = 30,
            };

            subPanel1.Controls.Add(Name);
            subPanel1.Controls.Add(Price);
            subPanel1.Controls.Add(Num);
            subPanel1.Controls.Add(Subtotal);

            return subPanel1;
        }
    }
}