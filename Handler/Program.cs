using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Order order = new Order();
            order.RegistEvent += Order_handler;
            order.AddOrder();
            Console.ReadKey();
        }

        private static void Order_handler(object sender, EventArgs e)
        {
            Console.WriteLine("AAA");
        }
    }
}