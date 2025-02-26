using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler
{
    internal class ShowPanel
    {
        public ShowPanel()
        {
        }

        public static void Show()
        {
            Console.WriteLine("BBB");
            OrderHandler.Notify();
        }
    }
}