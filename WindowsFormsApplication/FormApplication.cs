using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormApplication : Form
    {
        public FormApplication()
        {
            InitializeComponent();
            controlTextBox.ErrorColor = Color.LightBlue;
            //controlTextBox.Regexp = @"(0[1 - 9] |[12][0 - 9] | 3[01])[- /.]";
            controlTextBox.Regexp = @"\d{3}";
            controlListBox.LoadList(typeof(PropertiesClass));
        }
    }
}