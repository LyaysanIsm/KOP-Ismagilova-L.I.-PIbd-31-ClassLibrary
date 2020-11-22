using DataAccessLayer.BindingModels;
using DataAccessLayer.Enums;
using DataAccessLayer.Interfaces;
using DataAccessLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace WinFormsView
{
    public partial class ProductCreationForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ICrudLogic<ProductBindingModel, ProductViewModel> logic;

        public ProductCreationForm(ICrudLogic<ProductBindingModel, ProductViewModel> logic)
        {
            InitializeComponent();
            LoadData();
            this.logic = logic;
        }

        private void LoadData()
        {
            var types = Enum.GetValues(typeof(MeasureUnit));
            List<string> units = new List<string>();
            foreach (var type in types)
            {
                units.Add(type.ToString());
            }
            comboBoxSelectedControl.LoadList(units);
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text)
                || string.IsNullOrWhiteSpace(comboBoxSelectedControl.SelectedText)) {
                MessageBox.Show("Необходимо заполнить все поля", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    logic.Create(new ProductBindingModel
                    {
                        Name = nameTextBox.Text,
                        Unit = (MeasureUnit)Enum.Parse(typeof(MeasureUnit), comboBoxSelectedControl.SelectedText),
                        DateOfSupply = supplyDatePicker.Value.Date
                    });
                    MessageBox.Show("Данные сохранены", "Уведомление",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
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
