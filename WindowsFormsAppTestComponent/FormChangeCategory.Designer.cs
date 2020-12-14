namespace WindowsFormsAppTestComponent
{
    partial class FormChangeCategory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.controlSelectedComboBoxEnum = new WindowsFormsControlLibrary.Selected.ControlSelectedComboBoxEnum();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Категория:";
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(36, 74);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(144, 23);
            this.buttonChange.TabIndex = 13;
            this.buttonChange.Text = "Изменить категорию";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // controlSelectedComboBoxEnum
            // 
            this.controlSelectedComboBoxEnum.Location = new System.Drawing.Point(12, 38);
            this.controlSelectedComboBoxEnum.Name = "controlSelectedComboBoxEnum";
            this.controlSelectedComboBoxEnum.SelectedIndex = -1;
            this.controlSelectedComboBoxEnum.SelectedItem = null;
            this.controlSelectedComboBoxEnum.Size = new System.Drawing.Size(201, 21);
            this.controlSelectedComboBoxEnum.TabIndex = 6;
            // 
            // FormChangeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 110);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlSelectedComboBoxEnum);
            this.Name = "FormChangeCategory";
            this.Text = "FormChangeCategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonChange;
        private WindowsFormsControlLibrary.Selected.ControlSelectedComboBoxEnum controlSelectedComboBoxEnum;
    }
}