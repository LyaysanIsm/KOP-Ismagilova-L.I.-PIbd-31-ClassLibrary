using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using ClassLibraryInterpreter;
using ClassLibraryPlugins.Models;

namespace WindowsFormsAppTestComponent
{
    public partial class FormCreate : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IProductLogic logic;

        public FormCreate(IProductLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
            controlSelectedComboBoxEnum.LoadEnum(typeof(Category));
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                logic.CreateOrUpdate(new ProductBindingModel
                {
                    Name = textBoxName.Text,
                    Category = (Category)controlSelectedComboBoxEnum.SelectedItem,
                    Count = controlnullableInt.Value,
                    KindOfProduct = userControlDecorator.Kindofproduct,
                    Price = Int32.Parse(textBoxPrice.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttoncost_Click(object sender, EventArgs e)
        {
            userControlInterpreter.setExpression(new MultiplyExpression(new NumberExpression(Int32.Parse(textBoxPrice.Text)),
            new NumberExpression(Convert.ToInt32(controlnullableInt.Value))));
            textBoxCost.Text = userControlInterpreter.Result.ToString();
        }
    }
}