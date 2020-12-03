using ApplicationLogic.BindingModels;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Mediators;
using ApplicationLogic.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ApplicationView
{
    public partial class DeliveryForm : Form
    {
        private ProductMediator productMediator;
        private readonly ICrudLogic<Warehouse> warehouseLogic;
        private readonly ICrudLogic<Product> productLogic;

        public DeliveryForm(ICrudLogic<Warehouse> logic, ICrudLogic<Product> prodLogic)
        {
            InitializeComponent();
            this.productLogic = prodLogic;
            this.warehouseLogic = logic;
        }

        private void InitData()
        {
            List<Product> products = productLogic.Read(null);
            productComboBox.DataSource = products;
            productComboBox.DisplayMember = "Name";
            productMediator = new ProductMediator(warehouseLogic.Read(null));
            productMediator.Status += PrintNotification;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text)
                || productComboBox.SelectedItem == null)
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    productMediator.OrderDelivery(new DeliveryDataBindingModel
                    {
                        Address = addressTextBox.Text,
                        ProductName = ((Product)productComboBox.SelectedItem).Name
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void PrintNotification(string message)
        {
            notificationTextBox.Text += message;
            notificationTextBox.Text += Environment.NewLine;
        }
    }
}
