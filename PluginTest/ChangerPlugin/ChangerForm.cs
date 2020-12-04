using PluginsInterfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChangerPlugin
{
    public partial class ChangerForm : Form
    {
        private readonly IPlugin plugin;
        private readonly DataBindingModel model;

        public ChangerForm(IPlugin plugin, DataBindingModel model)
        {
            InitializeComponent();
            this.plugin = plugin;
            this.model = model;
        }

        private void ChangerForm_Load(object sender, EventArgs e)
        {
            Text = plugin.Name + plugin.Version;
            InitData(model.Type);
        }

        private void InitData(Type type)
        {
            try
            {
                foreach (var value in Enum.GetValues(type))
                {
                    enumListView.Items.Add(value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (enumListView.SelectedItems.Count > 0)
            {
                model.ChosenElement = enumListView.SelectedItems[0].Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Выберите значение", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}