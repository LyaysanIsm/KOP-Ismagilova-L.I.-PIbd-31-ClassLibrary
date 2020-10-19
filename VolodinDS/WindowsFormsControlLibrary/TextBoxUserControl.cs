using System;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary
{
    public partial class TextBoxUserControl : UserControl
    {
        /// <summary>
        /// Возвращает введенный в поле текст, если поле непустое
        /// </summary>
        public string InputText
        {
            get
            {
                return string.IsNullOrEmpty(textBox.Text) ? null : textBox.Text;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public TextBoxUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработка события Mouse_Leave. Вызывает диалоговое окно с ошибкой,
        /// если текстовое поле не заполнено
        /// </summary>
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Поле должно быть заполнено!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Focus();
            }
        }
    }
}
