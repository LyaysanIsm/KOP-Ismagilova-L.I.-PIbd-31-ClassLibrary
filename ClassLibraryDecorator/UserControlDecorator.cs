using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryDecorator
{
    public partial class UserControlDecorator : UserControl
    {
        public UserControlDecorator()
        {
            InitializeComponent();
        }

        private KindOfProductClass kindofproduct;

        public string Kindofproduct
        {
            get
            {
                return kindofproduct != null ? kindofproduct.getkindofproduct() : "Пусто";
            }
        }

        private void checkBoxNormal_CheckedChanged(object sender, EventArgs e)
        {
            KindOfProductDecoratorClass decorator = new NormalProduct();
            kindofproduct = decorator;

        }

        private void checkBoxLuxury_CheckedChanged(object sender, EventArgs e)
        {
            KindOfProductDecoratorClass decorator = new LuxuryProduct();
            kindofproduct = decorator;
        }
    }
}
