using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace 點餐
{
    public partial class Form1 : Form
    {
        readonly List<FlowLayoutPanel> panels = null;

        readonly Order order = null;

        public Form1()
        {
            InitializeComponent();

            order = new Order();
            order.RegistEvent += OrderHandler;

            panels = new List<FlowLayoutPanel>
            { flowLayoutPanel1, flowLayoutPanel2, flowLayoutPanel3, flowLayoutPanel4 };

            this.CreateFoodSelectionPanel();

            this.AddItems();
        }

        private void AddItems()
        {
            string[] items = {
                "咖哩飯買二送一",
                "排骨飯送可樂",
                "雞腿飯三個250",
                "全場85折",
                "消費滿300折50",
                "套餐A-雞腿飯加點沙士100元"};

            foreach (string item in items)
            {
                comboBox1.Items.Add(item);
            }
        }

        static readonly List<string> mainDish = new List<string> { "咖哩飯$65", "排骨飯$80", "雞腿飯$90" };
        static readonly List<string> sideDish = new List<string> { "青椒$20", "菠菜$10" };
        static readonly List<string> dessert = new List<string> { "巧克力$20", "冰$20" };
        static readonly List<string> drink = new List<string> { "可樂$20", "沙士$20" };

        readonly List<List<string>> foods = new List<List<string>>
        {
            mainDish,
            sideDish,
            dessert,
            drink
        };

        private void CreateFoodSelectionPanel()
        {
            for (int i = 0; i < panels.Count; i++)
            {
                AddFoodSelection(foods[i], panels[i]);
            }
        }

        private void AddFoodSelection(List<string> foods, FlowLayoutPanel panel)
        {
            for (int i = 0; i < foods.Count; i++)
            {
                FlowLayoutPanel subPanel = new FlowLayoutPanel();

                CheckBox checkBox = new CheckBox
                {
                    Text = foods[i]
                };
                checkBox.CheckedChanged += SelectedFood;

                NumericUpDown upDown = new NumericUpDown
                {
                    Width = 50
                };
                upDown.ValueChanged += ChooseNumber;

                subPanel.Controls.Add(checkBox);
                subPanel.Controls.Add(upDown);

                panel.Controls.Add(subPanel);
            }
        }

        private void ChooseNumber(object sender, EventArgs e)
        {
            NumericUpDown upDown = (NumericUpDown)sender;
            FlowLayoutPanel panel = upDown.Parent as FlowLayoutPanel;
            CheckBox checkBox = panel.Controls[0] as CheckBox;

            checkBox.Checked = upDown.Value != 0;

            OrderMeal(checkBox, upDown);
        }

        private void SelectedFood(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            FlowLayoutPanel panel = checkBox.Parent as FlowLayoutPanel;
            NumericUpDown upDown = panel.Controls[1] as NumericUpDown;

            upDown.Value = checkBox.Checked ? 1 : 0;

            OrderMeal(checkBox, upDown);
        }

        private void OrderMeal(CheckBox checkBox, NumericUpDown upDown)
        {
            (string item, int amount) = Extension.SplitItemAndAmount(checkBox.Text);
            Meal meal = new Meal(item, amount, (int)upDown.Value);
            Order.AddOrder(meal, comboBox1.Text);
        }

        private void OrderHandler(object sender, FlowLayoutPanel panel)
        {
            flowLayoutPanel5.Controls.Clear();

            flowLayoutPanel5.Controls.Add(panel);

            totalLab.Text = Order.GetAmount().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string discount = comboBox1.Text;
            Order.AddOrder(null, discount);
        }
    }
}