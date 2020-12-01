using ApplicationLogic.Abstract;
using ApplicationLogic.Decorators;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ApplicationView
{
    public partial class OrderCreationForm : Form

    {
        private readonly ICrudLogic<Product> productLogic;
        private readonly ICrudLogic<Order> orderLogic;

        public OrderCreationForm(ICrudLogic<Product> productLogic, 
            ICrudLogic<Order> orderLogic)
        {
            InitializeComponent();
            this.productLogic = productLogic;
            this.orderLogic = orderLogic;
        }

        private void LoadData()
        {
            List<Product> products = productLogic.Read(null);
            productComboBox.DataSource = products;
            productComboBox.DisplayMember = "Name";
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (productComboBox.SelectedItem == null ||
                string.IsNullOrWhiteSpace(countTextBox.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    AbstractDelivery delivery;
                    if (pickUpPointButton.Checked)
                    {
                        delivery = new DefaultDelivery();
                    }
                    else
                    {
                        delivery = new CourierDelivery();
                    }
                    if (withCheckCheckBox.Checked)
                    {
                        delivery = new DeliveryWithCheck(delivery);
                    }
                    if (contactlessCheckBox.Checked)
                    {
                        delivery = new ContactlessDelivery(delivery);
                    }
                    orderLogic.Create(new Order
                    {
                        Product = (Product)productComboBox.SelectedItem,
                        Count = int.Parse(countTextBox.Text),
                        Delivery = delivery.GetInfo()
                    });
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void OrderCreationForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
