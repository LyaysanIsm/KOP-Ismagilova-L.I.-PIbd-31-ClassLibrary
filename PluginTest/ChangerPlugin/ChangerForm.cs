using PluginsInterfaces;
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

        private void ChangerForm_Load(object sender, EventArgs e)
        {
            Text = $"{plugin.Name} {plugin.Version}";
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
                plugin.UpdateObject(enumListView.SelectedItems[0].Text);
                Close();
            }
            else
            {
                MessageBox.Show("Выберите значение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnumListView_DragEnter(object sender, DragEventArgs e)
        {
                e.Effect = DragDropEffects.Copy;
        }

        private void EnumListView_DragDrop(object sender, DragEventArgs e)
        {
            plugin.TargetObject = e.Data.GetData(e.Data.GetFormats()[0]);
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