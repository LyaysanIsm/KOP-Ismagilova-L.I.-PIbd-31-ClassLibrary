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
using MigraDoc.DocumentObjectModel.Shapes.Charts;

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

            string temp = "(Id) (Name) (Age)";
            controlListBox2.setTemplate(temp);
            var set1 = new Student { Name = "Ivan", Items = 10, Course = 2, Age = 20, Id = 1 };
            var set2 = new Student { Name = "Andrey", Items = 10, Course = 2, Age = 21, Id = 2 };
            var set3 = new Student { Name = "Dmitriy", Items = 15, Course = 3, Age = 23, Id = 3 };
            var set4 = new Student { Name = "Petya", Items = 20, Course = 4, Age = 30, Id = 4 };

            controlListBox2.setProperty(set1, "Name", 1);
            controlListBox2.setProperty(set2, "Age", 3);

            var list = new List<Student>();
            list.Add(set1);
            list.Add(set2);
            list.Add(set3);
            list.Add(set4);

            set1.Id = 1;
            set1.Age = 20;
            set1.Items = 15;
            set1.Course = 3;

            int[] toMerge = new int[] { 2, 2, 1 };
           

            //binaryComponent.saveData<Student>("D:/1/2/3", list.ToArray());
            excelComponent.CreateExcelReport("D:/1/2/3/excel.xlsx", true, list.ToArray(), toMerge);
            pdfComponent.CreatePdfDiagram("D:/1/2/3/pdf.pdf", set1, DataLabelType.Value);
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