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
        public string reg = "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9][0-9]";

        private string userInput = string.Empty;
        private string temp = "08.02.2015";

        public void setTemp(string str)
        {
            textBox.Text = str;
        }

        public void leaveTemp()
        {
            temp = "";
            textBox.Text = "";
        }


        public ControlTextFieldData()
        {
            InitializeComponent();
            textBox.Text = temp;
        }

        [Category("Спецификация"), Description("Значение корректно")]
        public string UserInput
        {
            get
            {
                return checkReg() ? userInput : string.Empty;
            }
            set
            {
                userInput = value;
                textBox.Text = userInput;
            }
        }

        [Category("Спецификация"), Description("Значение некорректно")]
        public Color ErrorColor
        {
            get; set;
        }
        public bool checkReg()
        {
            return Regex.IsMatch(textBox.Text, reg);
        }

        private bool checkUserInpit()
        {
            return userInput.Length > 0;
        }

        private void showUserInput()
        {
            textBox.Text = userInput;
            textBox.ForeColor = Color.Black;
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (checkUserInpit())
            {
                showUserInput();
            }
        }

        private string Check()
        {
            if (!string.IsNullOrEmpty(textBox.Text))
                return userInput = textBox.Text;
            else
                return string.Empty;
        }

        private void inputText(object sender, EventArgs e)
        {
            showUserInput();
        }
        private void textBox_Print(object sender, EventArgs e)
        {
            Check();
            if (checkReg())
            {
                textBox.BackColor = Color.White;
            }
            else
            {
                textBox.BackColor = ErrorColor;
            }
        }
        private void Form_Load(object sender, System.EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.ToolTipTitle = "Формат ввода:";
            toolTip.Active = true;
            toolTip.UseAnimation = true;
            toolTip.ShowAlways = true;
            toolTip.SetToolTip(this.textBox, "dd.mm.yyyy");
        }

        private void textBox_MouseDown(object sender, MouseEventArgs e)
        {
            temp = "";
            textBox.Text = "";
        }
    }
}