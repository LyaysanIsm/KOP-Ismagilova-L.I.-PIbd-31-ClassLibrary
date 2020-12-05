using ApplicationLogic.DataAccessLogic;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using PluginsInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace PluginTestView
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ICrudLogic<Supply> supplyLogic;
        private readonly ICrudLogic<Product> productLogic;
        private readonly PluginLogic pluginLogic;
        private List<IPlugin> plugins;

        public MainForm(PluginLogic pluginLogic, ICrudLogic<Supply> supplyLogic, 
            ICrudLogic<Product> productLogic)
        {
            InitializeComponent();
            this.productLogic = productLogic;
            this.supplyLogic = supplyLogic;
            this.pluginLogic = pluginLogic;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadSupplies();
            LoadPlugins();
        }

        private void LoadPlugins()
        {
            try
            {
                plugins = pluginLogic.GetPlugins();
                foreach (var plugin in plugins)
                {
                    pluginsListView.Items.Add(new ListViewItem(new string[]
                    {
                        plugin.Name,
                        plugin.Version
                    }));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            productsListView.Items.Clear();
            List<Product> products = productLogic.Read(null);
            foreach (Product product in products)
            {
                productsListView.Items.Add(new ListViewItem(new string[]
                {
                    product.Name,
                    product.Unit.ToString(),
                    product.Price.ToString()
                }));
            }
        }

        private void LoadSupplies()
        {
            List<Supply> supplies = supplyLogic.Read(null);
            foreach (Supply supply in supplies)
            {
                suppliesListView.Items.Add(new ListViewItem(new string[] 
                { 
                    supply.Date.ToShortDateString(), 
                    supply.Product.Name, 
                    supply.Count.ToString()
                }));
            }
        }

        private void NewProductButton_Click(object sender, EventArgs e)
        {
            ProductCreationForm productCreationForm = Container.Resolve<ProductCreationForm>();
            if (productCreationForm.ShowDialog() == DialogResult.OK)
            {
                LoadProducts();
            }
        }

        private void ProductsListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            Product toDrag = productLogic.Read(new Product
            {
                Name = productsListView.SelectedItems[0].SubItems[0].Text
            }).First();
            productsListView.DoDragDrop(toDrag, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void PluginsListView_DoubleClick(object sender, EventArgs e)
        {
            if (pluginsListView.SelectedItems.Count > 0)
            {
                plugins[pluginsListView.SelectedItems[0].Index].ActionDone += LoadProducts;
                plugins[pluginsListView.SelectedItems[0].Index].Activate();
            }
        }
    }
}
