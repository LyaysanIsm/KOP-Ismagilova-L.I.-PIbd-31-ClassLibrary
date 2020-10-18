using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryListBox2;

namespace WindowsFormsApplication
{
    public partial class FormApplication : Form
    {
        public FormApplication()
        {
            InitializeComponent();

            controlComboBox.LoadCombo(TestEnum.Значение1);
            controlComboBox.LoadCombo(TestEnum.Значение2);

            controlTextBox.ErrorColor = Color.LightBlue;
            controlTextBox.Regexp = @"\d{2}.";
            controlTextBox.Hint = @"10.";

            controlListBox.LoadList(typeof(PropertiesClass));

            string temp = "(Id) (Time) (Number)";
            controlListBox2.setTemplate(temp);
            var set1 = new Bus { Id = 0, Time = 197, Number = 56 };
            var set2 = new Bus { Id = 1, Time = 148, Number = 36 };
            var set3 = new Bus { Id = 2, Time = 260, Number = 59 };
            var set4 = new Bus { Id = 3, Time = 115, Number = 96 };

            controlListBox2.setProperty(set1, "Number", 1);
            controlListBox2.setProperty(set2, "Id", 3);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboBox.SelectedIndex = 0;
        }

        private void controlComboBox_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlComboBox.SelectedIndex.ToString() + " " + controlComboBox.SelectedText);
        }
    }
}