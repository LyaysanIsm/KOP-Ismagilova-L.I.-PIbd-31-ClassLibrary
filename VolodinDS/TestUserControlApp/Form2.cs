using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TestUserControlApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            TestDeserialization();
        }


        private void TestSerialization()
        {
            string dir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = "worker.dat";
            string source = Path.Combine(dir, filename);
            using (FileStream fs = new FileStream(source, FileMode.Create))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, new Worker
                {
                    FIO = "Иванов Иван Иванович",
                    Dept = "Отдел тестирования ПО",
                    Position = "Главный тестировщик"
                });
            }
        }

        private void TestDeserialization()
        {
            textBox.Text = "Работник: \n";
            var zipDialog = new OpenFileDialog();
            if (zipDialog.ShowDialog() == DialogResult.OK)
            {
                Worker worker = restoreFromBinary.Deserialize<Worker>(zipDialog.FileName, "worker.dat");
                textBox.Text = $"{worker.FIO}\n{worker.Dept}\n{worker.Position}";
            }
        }
    }
}
