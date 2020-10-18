﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormApplication : Form
    {
        public FormApplication()
        {
            InitializeComponent();
            controlTextBox.ErrorColor = Color.LightBlue;
            controlTextBox.Regexp = @"\d{2}.";
            controlTextBox.Hint = @"10.";
            controlListBox.LoadList(typeof(PropertiesClass));
            List<string> strList = new List<string> { "Значение 1", "Значение 2", "Значение 3", "Значение 4", "Значение 5" };
            controlComboBox.LoadObject(strList);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            controlComboBox.SelectedIndex = 0;
        }

        private void controlComboBox_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(controlComboBox.SelectedIndex.ToString() + " " + controlComboBox.SelectedText);
        }
    }
}