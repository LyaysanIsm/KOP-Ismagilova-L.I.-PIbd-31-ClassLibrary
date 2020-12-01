
namespace ApplicationView
{
    partial class OrderCreationForm
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
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.deliveryLabel = new System.Windows.Forms.Label();
            this.pickUpPointButton = new System.Windows.Forms.RadioButton();
            this.courierButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.withCheckCheckBox = new System.Windows.Forms.CheckBox();
            this.contactlessCheckBox = new System.Windows.Forms.CheckBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(13, 38);
            this.productComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(392, 33);
            this.productComboBox.TabIndex = 0;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(14, 9);
            this.productLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(170, 25);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Выберите товар:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(14, 75);
            this.countLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(211, 25);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "Введите количество:";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(13, 103);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(392, 30);
            this.countTextBox.TabIndex = 3;
            // 
            // deliveryLabel
            // 
            this.deliveryLabel.AutoSize = true;
            this.deliveryLabel.Location = new System.Drawing.Point(14, 136);
            this.deliveryLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.deliveryLabel.Name = "deliveryLabel";
            this.deliveryLabel.Size = new System.Drawing.Size(169, 25);
            this.deliveryLabel.TabIndex = 4;
            this.deliveryLabel.Text = "Куда доставить?";
            // 
            // pickUpPointButton
            // 
            this.pickUpPointButton.AutoSize = true;
            this.pickUpPointButton.Checked = true;
            this.pickUpPointButton.Location = new System.Drawing.Point(13, 165);
            this.pickUpPointButton.Name = "pickUpPointButton";
            this.pickUpPointButton.Size = new System.Drawing.Size(180, 29);
            this.pickUpPointButton.TabIndex = 5;
            this.pickUpPointButton.TabStop = true;
            this.pickUpPointButton.Text = "В пункт выдачи";
            this.pickUpPointButton.UseVisualStyleBackColor = true;
            // 
            // courierButton
            // 
            this.courierButton.AutoSize = true;
            this.courierButton.Location = new System.Drawing.Point(12, 200);
            this.courierButton.Name = "courierButton";
            this.courierButton.Size = new System.Drawing.Size(212, 29);
            this.courierButton.TabIndex = 6;
            this.courierButton.Text = "Курьером до дома";
            this.courierButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 232);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Дополнительно:";
            // 
            // withCheckCheckBox
            // 
            this.withCheckCheckBox.AutoSize = true;
            this.withCheckCheckBox.Location = new System.Drawing.Point(12, 261);
            this.withCheckCheckBox.Name = "withCheckCheckBox";
            this.withCheckCheckBox.Size = new System.Drawing.Size(294, 29);
            this.withCheckCheckBox.TabIndex = 8;
            this.withCheckCheckBox.Text = "С проверкой при получении";
            this.withCheckCheckBox.UseVisualStyleBackColor = true;
            // 
            // contactlessCheckBox
            // 
            this.contactlessCheckBox.AutoSize = true;
            this.contactlessCheckBox.Location = new System.Drawing.Point(12, 296);
            this.contactlessCheckBox.Name = "contactlessCheckBox";
            this.contactlessCheckBox.Size = new System.Drawing.Size(271, 29);
            this.contactlessCheckBox.TabIndex = 9;
            this.contactlessCheckBox.Text = "Бесконтактная передача";
            this.contactlessCheckBox.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 331);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(394, 57);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Отправить данные";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OrderCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 400);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.contactlessCheckBox);
            this.Controls.Add(this.withCheckCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.courierButton);
            this.Controls.Add(this.pickUpPointButton);
            this.Controls.Add(this.deliveryLabel);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.OrderCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Label deliveryLabel;
        private System.Windows.Forms.RadioButton pickUpPointButton;
        private System.Windows.Forms.RadioButton courierButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox withCheckCheckBox;
        private System.Windows.Forms.CheckBox contactlessCheckBox;
        private System.Windows.Forms.Button submitButton;
    }
}