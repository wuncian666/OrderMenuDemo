using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 點餐
{
    internal class Meal
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Num { get; set; }
        public double Subtotal { get; set; }

        public Meal(string name, int price, int num)
        {
            Name = name;
            Price = price;
            Num = num;
            Subtotal = num * price;
        }
    }
}