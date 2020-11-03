using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TestUserControlApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        //private void TestSerialization()
        //{
        //    string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    string filename = "worker.dat";
        //    string source = Path.Combine(dir, filename);
        //    using (FileStream fs = new FileStream(source, FileMode.Create))
        //    {
        //        BinaryFormatter formatter = new BinaryFormatter();
        //        formatter.Serialize(fs, new Worker
        //        {
        //            FIO = "Иванов Иван Иванович",
        //            Dept = "Отдел тестирования ПО",
        //            Position = "Главный тестировщик"
        //        });
        //    }
        //}

        private void TestDeserialization()
        {
            textBox.Text = "Работник: \n";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Worker worker = restoreFromBinary.Deserialize<Worker>(openFileDialog.FileName, "worker.dat");
                textBox.Text += ($"{Environment.NewLine}{worker.FIO}{Environment.NewLine}" +
                    $"{worker.Dept}{Environment.NewLine}{worker.Position}");
            }
        }

        private void TestPDF()
        {
            DataTable table = new DataTable();
            DataColumn firstColumn = new DataColumn("Headers");
            DataColumn secondColumn = new DataColumn("FirstCol");
            DataColumn thirdColumn = new DataColumn("ThirdCol");

            table.Columns.Add(firstColumn);
            table.Columns.Add(secondColumn);
            table.Columns.Add(thirdColumn);

            table.Rows.Add("rowspan2", "cell_01", "cell_02");
            table.Rows.Add(null, "cell_11", "cell_12");
            table.Rows.Add("rowspan3", "cell_21", "cell_22");
            table.Rows.Add(null, "cell_31", "cell_32");
            table.Rows.Add(null, "cell_41", "cell_42");

            int[] headers = new int[] { 2, 3 };
            
            tablePDF.SetTableData(table, headers);
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                tablePDF.SaveDoc(saveFileDialog.FileName);
            }
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            TestDeserialization();
        }

        private void PdfButton_Click(object sender, EventArgs e)
        {
            TestPDF();
        }
    }
}
