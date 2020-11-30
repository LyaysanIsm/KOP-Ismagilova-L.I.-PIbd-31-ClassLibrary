namespace WindowsFormsAppTestComponent
{
    partial class FormCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.controlnullableInt = new WindowsFormsControlLibrary.Input.ControlInputNullableInt();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.controlSelectedComboBoxEnum = new WindowsFormsControlLibrary.Selected.ControlSelectedComboBoxEnum();
            this.userControlDecorator = new ClassLibraryDecorator.UserControlDecorator();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(78, 21);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(201, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Категория:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество:";
            // 
            // controlnullableInt
            // 
            this.controlnullableInt.Location = new System.Drawing.Point(78, 129);
            this.controlnullableInt.Name = "controlnullableInt";
            this.controlnullableInt.Size = new System.Drawing.Size(158, 33);
            this.controlnullableInt.TabIndex = 4;
            this.controlnullableInt.Value = null;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(102, 263);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(134, 26);
            this.buttonCreate.TabIndex = 5;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // controlSelectedComboBoxEnum
            // 
            this.controlSelectedComboBoxEnum.Location = new System.Drawing.Point(78, 79);
            this.controlSelectedComboBoxEnum.Name = "controlSelectedComboBoxEnum";
            this.controlSelectedComboBoxEnum.SelectedIndex = -1;
            this.controlSelectedComboBoxEnum.SelectedItem = null;
            this.controlSelectedComboBoxEnum.Size = new System.Drawing.Size(201, 21);
            this.controlSelectedComboBoxEnum.TabIndex = 6;
            //
            // userControlDecorator1
            // 
            this.userControlDecorator.Location = new System.Drawing.Point(12, 168);
            this.userControlDecorator.Name = "userControlDecorator";
            this.userControlDecorator.Size = new System.Drawing.Size(165, 89);
            this.userControlDecorator.TabIndex = 7;
            // 
            // FormCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 307);
            this.Controls.Add(this.userControlDecorator);
            this.Controls.Add(this.controlSelectedComboBoxEnum);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.controlnullableInt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Name = "FormCreate";
            this.Text = "FormCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary.Input.ControlInputNullableInt controlnullableInt;
        private WindowsFormsControlLibrary.Selected.ControlSelectedComboBoxEnum controlSelectedComboBoxEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreate;
        private ClassLibraryDecorator.UserControlDecorator userControlDecorator;
    }
}