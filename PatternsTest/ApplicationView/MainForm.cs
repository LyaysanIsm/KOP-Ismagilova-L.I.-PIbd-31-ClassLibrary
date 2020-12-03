using ApplicationLogic.BindingModels;
using ApplicationLogic.Factories;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace ApplicationView
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ProductFactory factory;
        private readonly ICrudLogic<Product> logic;
        public MainForm(ProductFactory factory, ICrudLogic<Product> logic)
        {
            InitializeComponent();
            this.factory = factory;
            this.logic = logic;
        }

        private void LoadData()
        {
            productGridView.Rows.Clear();
            List<Product> products = logic.Read(null);
            foreach (var product in products)
            {
                productGridView.Rows.Add(product.Name, product.Price,
                    product.Manufacturer.Name, product.Manufacturer.Country);
            }
        }

        private void AddProduct(Product product)
        {
            logic.Create(product);
            LoadData();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<OrdersForm>();
            form.ShowDialog();
        }

        private void DeliveryButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<DeliveryForm>();
            form.ShowDialog();
        }
    }
}
