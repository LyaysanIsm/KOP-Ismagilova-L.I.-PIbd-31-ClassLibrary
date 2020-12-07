using OpenModelsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CreationPlugin
{
    public partial class CreationForm : Form
    {
        private readonly CreationPlugin plugin;

        public CreationForm(CreationPlugin plugin)
        {
            InitializeComponent();
            this.plugin = plugin;
        }

        private void ProductTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ProductOpenModel)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void ProductTextBox_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                plugin.SetProduct((ProductOpenModel)e.Data.GetData(typeof(ProductOpenModel)));
                PrintProductData(plugin.GetProductData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintProductData(List<string> data)
        {
            productTextBox.Text = string.Empty;
            foreach (var param in data)
            {
                productTextBox.Text += param + Environment.NewLine;
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productTextBox.Text)
                || string.IsNullOrWhiteSpace(countTextBox.Text))
            {
                MessageBox.Show("Необходимо заполнить все данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    plugin.SetCount(countTextBox.Text);
                    plugin.SubmitData();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
