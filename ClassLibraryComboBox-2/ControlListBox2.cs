using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryListBox2
{
    public partial class ControlListBox2 : UserControl
    {
        private int _selectedIndex;
        private string temp;

        public ControlListBox2()
        {
            InitializeComponent();
        }

        [Category("Спецификация"), Description("Получение индекса")]
        public int SelectedIndex
        {
            get { return listBox2.SelectedIndex; }
            set
            {
                if (value > -2 && value < listBox2.Items.Count)
                {
                    _selectedIndex = value;
                    listBox2.SelectedIndex = _selectedIndex;
                }
            }
        }

        [Category("Спецификация"), Description("Получение текста выбранной записи")]
        public string SelectedText
        {
            get { return listBox2.Text; }
        }

        [Category("Спецификация"), Description("Установка шаблона")]
        public void setTemplate(string temp)
        {
            this.temp = temp;
        }

        [Category("Спецификация"), Description("Установка свойств")]
        public void setProperty<T>(T value, string propName, int line)
        {
            if (listBox2.Items.Count < line)
            {
                for (int i = listBox2.Items.Count + 1; i <= line + 1; i++)
                {
                    listBox2.Items.Add(temp);
                }
            }
            Type type = value.GetType();
            string name = "(" + propName + ")";
            var s = type.GetProperty(propName).GetValue(value, null);
            listBox2.Items[line] = listBox2.Items[line].ToString().Replace(name, s.ToString());
        }
    }
}