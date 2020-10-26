using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TestUserControlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetData();
        }

        private void SetData()
        {
            List<string> items = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                items.Add($"Строка №{i}");
            }
            checkedListControl.InsertItems(items);

            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < 2; i ++)
            {
                workers.Add(new Worker
                {
                    FIO = $"FIO {i}",
                    Position = $"Position {i}",
                    Dept = $"Dept {i}"
                });
            }
            workers.Add(new Worker
            {
                FIO = "FIO 1",
                Position = "Position 1",
                Dept = "Dept 2"
            });
            treeViewControl.SetPropsOrder("FIO", "Dept");
            treeViewControl.BuildTree<Worker>(workers);
            treeViewControl.Selected = "FIO 1";
        }

        private void GetTextButton_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = textBoxUserControl.InputText;
        }
    }
}
