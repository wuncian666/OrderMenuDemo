using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler
{
    internal class Order
    {
        public Order()
        { }

        public EventHandler RegistEvent
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

        public void AddOrder()
        {
            ShowPanel.Show();
        }
    }
}