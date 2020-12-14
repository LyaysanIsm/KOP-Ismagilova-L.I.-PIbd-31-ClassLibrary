using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using BusinessLogic.VIewModel;
using ClassLibraryPlugins;
using ClassLibraryPlugins.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppTestComponent
{
    public partial class FormAdd : Form
    {
        private string cng;
        private ProductViewModel product;
        private readonly PluginManager manager;
        private readonly IProductLogic logic;
        public FormAdd(string inputCng, ProductViewModel inputProduct, PluginManager inputManager, IProductLogic inputLogic)
        {
            InitializeComponent();
            cng = inputCng;
            product = inputProduct;
            manager = inputManager;
            logic = inputLogic;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (manager == null)
            {
                return;
            }
            Product obj = new Product
            {
                Id = product.Id,
                Name = product.Name,
                KindOfProduct = product.KindOfProduct,
                Category = product.Category,
                Count = product.Count
            };
            if (textBoxAdd.Text != null)
            {
                manager.AddsDict[cng](obj, Convert.ToInt32(textBoxAdd.Text));
                try
                {
                    logic.CreateOrUpdate(new ProductBindingModel
                    {
                        Id = obj.Id,
                        Name = obj.Name,
                        Category = obj.Category,
                        Count = obj.Count,
                        KindOfProduct = obj.KindOfProduct,
                        Price = obj.Price
                    });
                    MessageBox.Show("Склад пополнен", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}