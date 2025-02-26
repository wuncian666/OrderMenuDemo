using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 點餐
{
    internal class OrderHandler
    {
        public static event EventHandler<FlowLayoutPanel> handler;

        public static EventHandler<FlowLayoutPanel> Regist()
        {
            return handler;
        }

        public static void Notify(FlowLayoutPanel panel)
        {
            handler.Invoke(null, panel);
        }
    }
}