using ApplicationLogic.Enums;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Models;
using System;
using System.Windows.Forms;

namespace PluginTestView
{
    public partial class ProductCreationForm : Form
    {
        private readonly ICrudLogic<Product> logic;

        public ProductCreationForm(ICrudLogic<Product> logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text)
                || string.IsNullOrWhiteSpace(priceTextBox.Text)
                || unitListBox.SelectedItem == null)
            {
                MessageBox.Show("Не все поля заполнены", "Уведомление",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    logic.Create(new Product
                    {
                        Name = nameTextBox.Text,
                        Unit = (MeasureUnit)Enum.Parse(typeof(MeasureUnit), 
                        unitListBox.SelectedItem.ToString()),
                        Price = int.Parse(priceTextBox.Text)
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

        private void ProductCreationForm_Load(object sender, EventArgs e)
        {
            var enumValues = Enum.GetValues(typeof(MeasureUnit));
            unitListBox.DataSource = enumValues;
        }
    }
}
