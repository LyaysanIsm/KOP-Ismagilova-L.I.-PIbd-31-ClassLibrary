﻿namespace WindowsFormsApplication
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
            this.SuspendLayout();
            // 
            // controlTextBox
            // 
            this.controlTextBox.Location = new System.Drawing.Point(231, 12);
            this.controlTextBox.Name = "controlTextBox";
            this.controlTextBox.Size = new System.Drawing.Size(230, 119);
            this.controlTextBox.TabIndex = 3;
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 195);
            this.Controls.Add(this.controlTextBox);
            this.Name = "FormApplication";
            this.Text = "FormApplication";
            this.ResumeLayout(false);
        }

        #endregion        
        private ClassLibraryData.ControlTextFieldData controlTextBox;
    }
}