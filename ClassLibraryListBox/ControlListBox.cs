using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryListBox
{
    public partial class ControlListBox : UserControl
    {
        public ControlListBox()
        {
            InitializeComponent();
        }

        public void LoadList(Type cl)
        {
            foreach (var elem in cl.GetProperties())
            {
                listBox.Items.Add(elem.ToString());
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Индекс элемента:" + listBox.SelectedIndex + "  Строка:" + listBox.SelectedItem.ToString());
        }
    }
}