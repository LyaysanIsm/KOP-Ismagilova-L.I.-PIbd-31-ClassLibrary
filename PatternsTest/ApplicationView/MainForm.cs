using ApplicationLogic.BindingModels;
using ApplicationLogic.Factories;
using ApplicationLogic.Models;
using System;
using System.Windows.Forms;

namespace ApplicationView
{
    public partial class MainForm : Form
    {
        private readonly ProductFactory factory;
        public MainForm(ProductFactory factory)
        {
            InitializeComponent();
            this.factory = factory;
        }
        private void AddProduct(Product product)
        {
            productGridView.Rows.Add(product.Name, product.Price,
                product.Manufacturer.Name, product.Manufacturer.Country);
        }

        private void AppleButton_Click(object sender, EventArgs e)
        {
            ProductDataBindingModel model = GetModel();
            if (model != null)
            {
                AddProduct(factory.GetAppleSmartphone(model.Name, model.Price));
            }
        }


        private void SamsungButton_Click(object sender, EventArgs e)
        {
            ProductDataBindingModel model = GetModel();
            if (model != null)
            {
                AddProduct(factory.GetSamsungSmartphone(model.Name, model.Price));
            }
        }

        private void XiaomiButton_Click(object sender, EventArgs e)
        {
            ProductDataBindingModel model = GetModel();
            if (model != null)
            {
                AddProduct(factory.GetXiaomiSmartphone(model.Name, model.Price));
            }
        }

        private ProductDataBindingModel GetModel()
        {
            ProductDataBindingModel model = new ProductDataBindingModel();
            var creationForm = new ProductCreationForm(model);
            if (creationForm.ShowDialog() == DialogResult.OK)
            {
                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
