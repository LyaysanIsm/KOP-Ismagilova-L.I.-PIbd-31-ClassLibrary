
namespace WinFormsView
{
    partial class ProductCreationForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.measureUnitLabel = new System.Windows.Forms.Label();
            this.supplyDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.comboBoxSelectedControl = new WinFormsElemsLibrary.ComboBoxSelectedControl();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 32);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(302, 26);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(87, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Название:";
            // 
            // measureUnitLabel
            // 
            this.measureUnitLabel.AutoSize = true;
            this.measureUnitLabel.Location = new System.Drawing.Point(12, 78);
            this.measureUnitLabel.Name = "measureUnitLabel";
            this.measureUnitLabel.Size = new System.Drawing.Size(166, 20);
            this.measureUnitLabel.TabIndex = 2;
            this.measureUnitLabel.Text = "Единица измерения:";
            // 
            // supplyDatePicker
            // 
            this.supplyDatePicker.Location = new System.Drawing.Point(12, 166);
            this.supplyDatePicker.Name = "supplyDatePicker";
            this.supplyDatePicker.Size = new System.Drawing.Size(302, 26);
            this.supplyDatePicker.TabIndex = 3;
            this.supplyDatePicker.Value = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Дата поставки:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 198);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(302, 50);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Отправить данные";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // comboBoxSelectedControl
            // 
            this.comboBoxSelectedControl.Location = new System.Drawing.Point(-4, 102);
            this.comboBoxSelectedControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSelectedControl.Name = "comboBoxSelectedControl";
            this.comboBoxSelectedControl.SelectedIndex = "-1";
            this.comboBoxSelectedControl.Size = new System.Drawing.Size(162, 37);
            this.comboBoxSelectedControl.TabIndex = 6;
            // 
            // ProductCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 262);
            this.Controls.Add(this.comboBoxSelectedControl);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplyDatePicker);
            this.Controls.Add(this.measureUnitLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Name = "ProductCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Продукт";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label measureUnitLabel;
        private System.Windows.Forms.DateTimePicker supplyDatePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button submitButton;
        private WinFormsElemsLibrary.ComboBoxSelectedControl comboBoxSelectedControl;
    }
}