using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 點餐
{
    internal abstract class Discount
    {
        public abstract void ImplDiscount(List<Meal> meals);
    }
}