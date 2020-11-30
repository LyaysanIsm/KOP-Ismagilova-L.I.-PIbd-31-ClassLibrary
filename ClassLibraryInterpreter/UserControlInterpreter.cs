using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryInterpreter
{
    public partial class UserControlInterpreter : UserControl
    {
        private int count;
        private int price;
        private string cost;

        public int Count
        {
            set
            {
                count = value;
            }
        }

        public int Price
        {
            set
            {
                price = value;
            }
        }

        public string Cost
        {
            get
            {
                return cost;
            }
        }

        public UserControlInterpreter()
        {
            InitializeComponent();
        }

        private void buttonCost_Click(object sender, EventArgs e)
        {
            if (count != 0 && price != 0)
            {
                IExpression expre = null;
                expre = new MultiplyExpression(new NumberExpression(count), new NumberExpression(price));
                if (expre != null)
                {
                    cost = expre.ToString();
                }
            }
        }
    }
}