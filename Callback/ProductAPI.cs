using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Callback
{
    internal class ProductAPI
    {
        private IProductCallBack callBack1 = null;

        public ProductAPI(IProductCallBack callBack)
        {
            callBack1 = callBack;
        }

        public void CallAPI()
        {
            // response
            string response = "MacBook 32GB";
            callBack1.GetProduct(response);
        }
    }
}