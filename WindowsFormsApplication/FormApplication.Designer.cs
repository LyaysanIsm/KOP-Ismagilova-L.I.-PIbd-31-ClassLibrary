namespace WindowsFormsApplication
{
    partial class FormApplication
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChange = new System.Windows.Forms.Button();
            this.controlTextBox = new ClassLibraryData.ControlTextFieldData();
            this.controlListBox2 = new ClassLibraryListBox2.ControlListBox2();
            this.controlComboBox = new ClassLibraryComboBox.ControlComboBox();
            this.excelComponent = new ClassLibraryExcelReport.ExcelComponent();
            this.binaryComponent = new ClassLibraryBinaryBackup.BinaryComponent();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(37, 85);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(106, 23);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Сменить";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // controlTextBox
            // 
            this.controlTextBox.ErrorColor = System.Drawing.Color.Empty;
            this.controlTextBox.Hint = "08.02.2015";
            this.controlTextBox.Location = new System.Drawing.Point(189, 40);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Regexp = "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9][0-9]";
            this.controlTextBox.Size = new System.Drawing.Size(205, 26);
            this.controlTextBox.TabIndex = 3;
            // 
            // controlListBox2
            // 
            this.controlListBox2.Location = new System.Drawing.Point(419, 40);
            this.controlListBox2.Name = "controlListBox2";
            this.controlListBox2.SelectedIndex = -1;
            this.controlListBox2.Size = new System.Drawing.Size(224, 139);
            this.controlListBox2.TabIndex = 4;
            // 
            // controlComboBox
            // 
            this.controlComboBox.Location = new System.Drawing.Point(12, 12);
            this.controlComboBox.Name = "controlComboBox";
            this.controlComboBox.SelectedIndex = -1;
            this.controlComboBox.Size = new System.Drawing.Size(162, 67);
            this.controlComboBox.TabIndex = 0;
            this.controlComboBox.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBox_ListBoxSelectedElementChange);
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 258);
            this.Controls.Add(this.controlTextBox);
            this.Controls.Add(this.controlListBox2);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.controlComboBox);
            this.Name = "FormApplication";
            this.Text = "FormApplication";
            this.ResumeLayout(false);

        }

        #endregion        
        private ClassLibraryData.ControlTextFieldData controlTextBox;
        private ClassLibraryListBox2.ControlListBox2 controlListBox2;
        private ClassLibraryComboBox.ControlComboBox controlComboBox;
        private System.Windows.Forms.Button buttonChange;
        private ClassLibraryExcelReport.ExcelComponent excelComponent;
        private ClassLibraryBinaryBackup.BinaryComponent binaryComponent;
    }
}