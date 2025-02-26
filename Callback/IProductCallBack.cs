using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback
{
    internal interface IProductCallBack
    {
        void GetProduct(string response);
    }
}