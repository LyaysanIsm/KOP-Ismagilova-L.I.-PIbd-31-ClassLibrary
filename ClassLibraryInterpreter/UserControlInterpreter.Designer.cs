namespace ClassLibraryInterpreter
{
    partial class UserControlInterpreter
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
            this.buttonCost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCost
            // 
            this.buttonCost.Location = new System.Drawing.Point(3, 3);
            this.buttonCost.Name = "buttonCost";
            this.buttonCost.Size = new System.Drawing.Size(144, 23);
            this.buttonCost.TabIndex = 1;
            this.buttonCost.Text = "Рассчитать стоимость";
            this.buttonCost.UseVisualStyleBackColor = true;
            this.buttonCost.Click += new System.EventHandler(this.buttonCost_Click);
            // 
            // UserControlInterpreter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonCost);
            this.Name = "UserControlInterpreter";
            this.Size = new System.Drawing.Size(150, 30);
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button buttonCost;
    }
}