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
            this.controlListBox = new ClassLibraryListBox.ControlListBox();
            this.controlComboBox = new ClassLibraryComboBox.ControlComboBox();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(53, 94);
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
            this.controlTextBox.Location = new System.Drawing.Point(288, 48);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Regexp = "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9][0-9]";
            this.controlTextBox.Size = new System.Drawing.Size(205, 26);
            this.controlTextBox.TabIndex = 3;
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(535, 37);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.Size = new System.Drawing.Size(223, 291);
            this.controlListBox.TabIndex = 0;
            // 
            // controlComboBox
            // 
            this.controlComboBox.Location = new System.Drawing.Point(24, 21);
            this.controlComboBox.Name = "controlComboBox";
            this.controlComboBox.SelectedIndex = 0;
            this.controlComboBox.Size = new System.Drawing.Size(162, 67);
            this.controlComboBox.TabIndex = 0;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 338);
            this.Controls.Add(this.controlTextBox);
            this.Controls.Add(this.controlListBox);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.controlComboBox);
            this.Name = "FormApplication";
            this.Text = "FormApplication";
            this.ResumeLayout(false);

        }

        #endregion        
        private ClassLibraryData.ControlTextFieldData controlTextBox;
        private ClassLibraryListBox.ControlListBox controlListBox;
        private ClassLibraryComboBox.ControlComboBox controlComboBox;
        private System.Windows.Forms.Button buttonChange;
    }
}