using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Callback
{
    public partial class Form1 : Form, IProductCallBack
    {
        public Form1()
        {
            InitializeComponent();
            ProductAPI product =  new ProductAPI(this);
            product.CallAPI();
        }

        public void GetProduct(string response)
        {
            label1.Text = response; 
        }
    }
}
