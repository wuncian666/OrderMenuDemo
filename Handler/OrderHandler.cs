using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handler
{
    internal class OrderHandler
    {
        public OrderHandler()
        {
        }

        public static event EventHandler handler;

        public static EventHandler Regist()
        {
            return handler;
        }

        public static void Notify()
        {
            handler.Invoke(null, null);
        }
    }
}