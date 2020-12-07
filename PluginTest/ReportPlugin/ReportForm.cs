using OpenModelsLibrary.Models;
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

namespace ReportPlugin
{
    public partial class ReportForm : Form
    {
        private readonly ReportPlugin plugin;

        public ReportForm(ReportPlugin plugin)
        {
            InitializeComponent();
            this.plugin = plugin;
        }

        private void SupplyInfoTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(SupplyOpenModel)))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void SupplyInfoTextBox_DragDrop(object sender, DragEventArgs e)
        {
            SupplyOpenModel supply = (SupplyOpenModel) e.Data.GetData(typeof(SupplyOpenModel));
            try
            {
                plugin.SetSupply(supply);
                PrintSupplyData(plugin.GetSupplyData());
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintSupplyData(List<string> data)
        {
            foreach (var param in data)
            {
                supplyInfoTextBox.Text += param + Environment.NewLine;
            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(supplyInfoTextBox.Text)
                || string.IsNullOrWhiteSpace(invoiceNumberTextBox.Text)
                || string.IsNullOrWhiteSpace(customerNameTextBox.Text)
                || string.IsNullOrWhiteSpace(customerAddressLabel.Text))
            {
                MessageBox.Show("Необходимо заполнить все данные", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    plugin.SetInvoiceNumber(invoiceNumberTextBox.Text);
                    plugin.SetCustomerName(customerNameTextBox.Text);
                    plugin.SetCustomerAddress(customerAddressTextBox.Text);
                    PrintForm printForm = new PrintForm(plugin);
                    if (printForm.ShowDialog() == DialogResult.OK)
                    {
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
