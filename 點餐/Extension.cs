using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 點餐
{
    internal static class Extension
    {
        public static int CalcCount(this string str)
        {
            return str.Length;
        }

        public static int GetMealAmount(this FlowLayoutPanel panel)
        {
            int result = 0;

            foreach (FlowLayoutPanel subPanel in panel.Controls)
            {
                CheckBox checkBox = subPanel.Controls[0] as CheckBox;
                NumericUpDown upDown = subPanel.Controls[1] as NumericUpDown;

                if (checkBox.Checked)
                {
                    (string item, int amount) = SplitItemAndAmount(checkBox.Text);
                    result += amount * (int)upDown.Value;
                }
            }

            return result;
        }

        public static List<Meal> GetMealDetail(this FlowLayoutPanel panel)
        {
            List<Meal> detail = new List<Meal>();

            foreach (FlowLayoutPanel subPanel in panel.Controls)
            {
                CheckBox checkBox = subPanel.Controls[0] as CheckBox;
                NumericUpDown upDown = subPanel.Controls[1] as NumericUpDown;

                if (checkBox.Checked)
                {
                    (string item, int amount) = SplitItemAndAmount(checkBox.Text);
                    Meal meal = new Meal(item, amount, (int)upDown.Value);
                    detail.Add(meal);
                }
            }

            return detail;
        }

        public static (string item, int amount) SplitItemAndAmount(String name)
        {
            string[] parts = name.Split('$');
            if (parts.Length != 2)
            {
                throw new ArgumentException("Invalid input format. Expected format: 'ItemName$Amount'.");
            }

            string itemName = parts[0];
            if (!int.TryParse(parts[1], out int amount))
            {
                throw new ArgumentException("Invalid amount. Expected an integer.");
            }

            return (itemName, amount);
        }
    }
}