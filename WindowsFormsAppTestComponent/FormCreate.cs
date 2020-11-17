using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using DataBaseImplement.Models;
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
                    Count = controlnullableInt.Value
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
    }
}