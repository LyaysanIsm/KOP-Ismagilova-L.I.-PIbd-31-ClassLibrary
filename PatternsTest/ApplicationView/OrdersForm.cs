using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace ApplicationView
{
    public partial class OrdersForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ICrudLogic<Order> logic;

        public OrdersForm(ICrudLogic<Order> logic)
        {
            InitializeComponent();
            this.logic = logic;
            LoadData();
        }

        private void LoadData()
        {
            ordersGridView.Rows.Clear();
            List<Order> orders = logic.Read(null);
            foreach (var order in orders)
            {
                ordersGridView.Rows.Add(order.Product.Name, 
                    order.Count, order.Delivery);
            }
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<OrderCreationForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
    }
}
