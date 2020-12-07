
namespace ReportPlugin
{
    partial class ReportForm
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
            this.supplyInfoTextBox = new System.Windows.Forms.TextBox();
            this.supplyInfoLabel = new System.Windows.Forms.Label();
            this.invoiceNumberLabel = new System.Windows.Forms.Label();
            this.invoiceNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supplyInfoTextBox
            // 
            this.supplyInfoTextBox.AllowDrop = true;
            this.supplyInfoTextBox.Location = new System.Drawing.Point(15, 29);
            this.supplyInfoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.supplyInfoTextBox.Multiline = true;
            this.supplyInfoTextBox.Name = "supplyInfoTextBox";
            this.supplyInfoTextBox.ReadOnly = true;
            this.supplyInfoTextBox.Size = new System.Drawing.Size(291, 98);
            this.supplyInfoTextBox.TabIndex = 1;
            this.supplyInfoTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.SupplyInfoTextBox_DragDrop);
            this.supplyInfoTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.SupplyInfoTextBox_DragEnter);
            // 
            // supplyInfoLabel
            // 
            this.supplyInfoLabel.AutoSize = true;
            this.supplyInfoLabel.Location = new System.Drawing.Point(12, 9);
            this.supplyInfoLabel.Name = "supplyInfoLabel";
            this.supplyInfoLabel.Size = new System.Drawing.Size(171, 16);
            this.supplyInfoLabel.TabIndex = 2;
            this.supplyInfoLabel.Text = "Информация о поставке:";
            // 
            // invoiceNumberLabel
            // 
            this.invoiceNumberLabel.AutoSize = true;
            this.invoiceNumberLabel.Location = new System.Drawing.Point(15, 131);
            this.invoiceNumberLabel.Name = "invoiceNumberLabel";
            this.invoiceNumberLabel.Size = new System.Drawing.Size(128, 16);
            this.invoiceNumberLabel.TabIndex = 3;
            this.invoiceNumberLabel.Text = "Номер накладной:";
            // 
            // invoiceNumberTextBox
            // 
            this.invoiceNumberTextBox.Location = new System.Drawing.Point(15, 150);
            this.invoiceNumberTextBox.Name = "invoiceNumberTextBox";
            this.invoiceNumberTextBox.Size = new System.Drawing.Size(292, 22);
            this.invoiceNumberTextBox.TabIndex = 4;
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(15, 175);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(110, 16);
            this.customerNameLabel.TabIndex = 5;
            this.customerNameLabel.Text = "Имя заказчика:";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(15, 194);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(292, 22);
            this.customerNameTextBox.TabIndex = 6;
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Location = new System.Drawing.Point(15, 219);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(124, 16);
            this.customerAddressLabel.TabIndex = 7;
            this.customerAddressLabel.Text = "Адрес заказчика:";
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Location = new System.Drawing.Point(15, 238);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(292, 22);
            this.customerAddressTextBox.TabIndex = 8;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(15, 267);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(292, 48);
            this.printButton.TabIndex = 10;
            this.printButton.Text = "Отправить на печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 334);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.invoiceNumberTextBox);
            this.Controls.Add(this.invoiceNumberLabel);
            this.Controls.Add(this.supplyInfoLabel);
            this.Controls.Add(this.supplyInfoTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Накладная на поставку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox supplyInfoTextBox;
        private System.Windows.Forms.Label supplyInfoLabel;
        private System.Windows.Forms.Label invoiceNumberLabel;
        private System.Windows.Forms.TextBox invoiceNumberTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.Button printButton;
    }
}