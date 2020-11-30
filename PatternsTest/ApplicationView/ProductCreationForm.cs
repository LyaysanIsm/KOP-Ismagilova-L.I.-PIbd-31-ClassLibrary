using ApplicationLogic.BindingModels;
using System;
using System.Windows.Forms;

namespace ApplicationView
{
    public partial class ProductCreationForm : Form
    {
        private readonly ProductDataBindingModel model;

        public ProductCreationForm(ProductDataBindingModel model)
        {
            InitializeComponent();
            this.model = model;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(modelTextBox.Text)
                || string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    model.Name = modelTextBox.Text;
                    model.Price = int.Parse(priceTextBox.Text);
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
    }
}
