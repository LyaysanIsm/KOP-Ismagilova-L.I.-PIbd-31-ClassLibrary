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
        private IExpression expression;

        public UserControlInterpreter()
        {
            InitializeComponent();
        }
        public int? Result
        {
            get
            {
                return expression?.Interpret();
            }
        }

        public void setExpression(IExpression expression)
        {
            this.expression = expression;
        }       
    }
}