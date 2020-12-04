using PluginsInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PluginTestView
{
    public partial class MainForm : Form
    {
        private List<IPlugin> plugins;

        public MainForm()
        {
            InitializeComponent();
        }

        public bool RegisterPlugin(IPlugin plugin)
        {
            return true;
        }

        private void AddPluginsToList()
        {
			pluginsListView.Items.Clear();
			foreach (var plugin in plugins)
            {
				pluginsListView.Items.Add(new ListViewItem(new string[] 
                { 
                    plugin.Name, 
                    plugin.Version 
                }));
            }
        }

        private void LoadData(string path)
        {
            plugins = new List<IPlugin>();
            string[] pluginFiles = Directory.GetFiles(path, "*Plugin.dll");

            foreach (string pluginFile in pluginFiles)
            {
				try
				{
					Assembly assembly = Assembly.LoadFrom(pluginFile);
					if (assembly != null)
					{
						var types = assembly.GetTypes();
						foreach (var type in types)
                        {
							try
                            {
								var instance = Activator.CreateInstance(type);
								if (instance is IPlugin)
								{
									plugins.Add(instance as IPlugin);
								}

                            } 
							catch
                            {
								continue;
                            }
                        }
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
			LoadData(Application.StartupPath);
			AddPluginsToList();
        }

        private void PluginsListView_DoubleClick(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Name = "Новый продукт",
                Unit = MeasureUnit.Килограммы
            };
			if (pluginsListView.SelectedItems.Count > 0)
            {
				if (plugins[pluginsListView.SelectedItems[0].Index].Activate(product))
                {
                    MessageBox.Show("Операция выполнена успешно", "Уведомление", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
