using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ClassLibraryData
{
    public partial class ControlTextFieldData : UserControl
    {
        /// <summary>
        /// Подсказка для пользователя
        /// </summary>
        private string hint = "08.02.2015";

        /// <summary>
        /// Пользователь вводит в строке
        /// </summary>
        private string userInput = string.Empty;

        /// <summary>
        /// Регулярное выражение в вводе
        /// </summary>
        private string regexp = @"(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9][0-9]$";
        /// <summary>
        /// Пользователь вводит в строке
        /// </summary>
        [Category("Спецификация"), Description("Пользователь вводит в строке")]
        public string UserInput
        {
            get { return checkInput() ? userInput : string.Empty; }
        }

        /// <summary>
        /// Цвет подсветки элемента при некорректном вводе
        /// </summary>
        [Category("Спецификация"), Description("Цвет подсветки элемента при некорректном вводе")]
        public Color ErrorColor
        {
            get; set;
        }

        /// <summary>
        /// Цвет подсветки элемента при некорректном вводе
        /// </summary>
        [Category("Спецификация"), Description("Установка шаблона для поля ввода")]
        public string Regexp
        {
            get { return regexp; }
            set { regexp = value.Length == 0 ? regexp : value; }
        }

        public ControlTextFieldData()
        {
            InitializeComponent();
            showHint();
        }

        private void textBox_Enter(object sender, EventArgs e)
        {
            showUserInput();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (userAlreadyPrintSomething())
            {
                showUserInput();
            }
            else
            {
                showHint();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            userInput = textBox.Text != hint ? textBox.Text : string.Empty;
            var isInputCorrect = checkInput();
            if (isInputCorrect)
            {
                textBox.BackColor = Color.White;
            }
            else
            {
                textBox.BackColor = ErrorColor;
            }
        }

        private bool checkInput()
        {
            return Regex.IsMatch(textBox.Text, regexp);
        }

        private void showUserInput()
        {
            textBox.Text = userInput;
            textBox.ForeColor = Color.Black;
        }

        private void showHint()
        {
            textBox.Text = hint;
            textBox.ForeColor = Color.Gray;
        }

        private bool userAlreadyPrintSomething()
        {
            return userInput.Length > 0;
        }
    }
}