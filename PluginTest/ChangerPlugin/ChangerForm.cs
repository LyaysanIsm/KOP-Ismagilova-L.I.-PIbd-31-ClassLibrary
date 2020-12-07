using OpenModelsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChangerPlugin
{
    public partial class ChangerForm : Form
    {
        private readonly ChangerPlugin plugin;

        public ChangerForm(ChangerPlugin plugin)
        {
            InitializeComponent();
            this.plugin = plugin;
        }

        private void InitData(List<string> values)
        {
            enumListView.Items.Clear();
            foreach (string value in values)
            {
                enumListView.Items.Add(value);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (enumListView.SelectedItems.Count > 0)
            {
                try
                {
                    plugin.UpdateObject(enumListView.SelectedItems[0].Text);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите значение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnumListView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(ProductOpenModel)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void EnumListView_DragDrop(object sender, DragEventArgs e)
        {
            plugin.Product = (ProductOpenModel)e.Data.GetData(typeof(ProductOpenModel));
            try
            {
                InitData(plugin.GetEnumValues());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}