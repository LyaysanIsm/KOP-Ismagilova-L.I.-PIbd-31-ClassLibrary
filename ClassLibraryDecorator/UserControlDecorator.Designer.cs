namespace ClassLibraryDecorator
{
    partial class UserControlDecorator
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxNormal = new System.Windows.Forms.CheckBox();
            this.checkBoxLuxury = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxNormal
            // 
            this.checkBoxNormal.AutoSize = true;
            this.checkBoxNormal.Location = new System.Drawing.Point(16, 18);
            this.checkBoxNormal.Name = "checkBoxNormal";
            this.checkBoxNormal.Size = new System.Drawing.Size(140, 17);
            this.checkBoxNormal.TabIndex = 0;
            this.checkBoxNormal.Text = "Обычное качество";
            this.checkBoxNormal.UseVisualStyleBackColor = true;
            this.checkBoxNormal.CheckedChanged += new System.EventHandler(this.checkBoxNormal_CheckedChanged);
            // 
            // checkBoxLuxury
            // 
            this.checkBoxLuxury.AutoSize = true;
            this.checkBoxLuxury.Location = new System.Drawing.Point(16, 56);
            this.checkBoxLuxury.Name = "checkBoxLuxury";
            this.checkBoxLuxury.Size = new System.Drawing.Size(122, 17);
            this.checkBoxLuxury.TabIndex = 1;
            this.checkBoxLuxury.Text = "Люксовое качество";
            this.checkBoxLuxury.UseVisualStyleBackColor = true;
            this.checkBoxLuxury.CheckedChanged += new System.EventHandler(this.checkBoxLuxury_CheckedChanged);
            // 
            // UserControlDecorator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxLuxury);
            this.Controls.Add(this.checkBoxNormal);
            this.Name = "UserControlDecorator";
            this.Size = new System.Drawing.Size(165, 89);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxNormal;
        private System.Windows.Forms.CheckBox checkBoxLuxury;
    }
}