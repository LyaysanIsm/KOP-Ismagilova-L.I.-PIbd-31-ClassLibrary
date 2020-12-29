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

            string temp = "(Id) (Name) (Age)";
            controlListBox2.setTemplate(temp);
            var set1 = new Student { Id = 0, Name = "Ivan", Age = 20 };
            var set2 = new Student { Id = 0, Name = "Andrey", Age = 21 };
            var set3 = new Student { Id = 0, Name = "Dmitriy", Age = 23 };
            var set4 = new Student { Id = 0, Name = "Petya", Age = 30 };

            controlListBox2.setProperty(set1, "Name", 1);
            controlListBox2.setProperty(set2, "Age", 3);
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