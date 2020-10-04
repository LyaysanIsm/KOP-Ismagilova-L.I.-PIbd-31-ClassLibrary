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
            this.controlTextBox = new ClassLibraryData.ControlTextFieldData();
            this.controlListBox = new ClassLibraryListBox.ControlListBox();
            this.SuspendLayout();
            // 
            // controlTextBox
            // 
            this.controlTextBox.ErrorColor = System.Drawing.Color.Empty;
            this.controlTextBox.Location = new System.Drawing.Point(498, 23);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Regexp = "(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)[0-9][0-9]$";
            this.controlTextBox.Size = new System.Drawing.Size(230, 119);
            this.controlTextBox.TabIndex = 3;
            // 
            // controlListBox
            // 
            this.controlListBox.Location = new System.Drawing.Point(230, 12);
            this.controlListBox.Name = "controlListBox";
            this.controlListBox.Size = new System.Drawing.Size(223, 291);
            this.controlListBox.TabIndex = 0;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 319);
            this.Controls.Add(this.controlTextBox);
            this.Controls.Add(this.controlListBox);
            this.Name = "FormApplication";
            this.Text = "FormApplication";
            this.ResumeLayout(false);

        }

        #endregion        
        private ClassLibraryData.ControlTextFieldData controlTextBox;
        private ClassLibraryListBox.ControlListBox controlListBox;
    }
}