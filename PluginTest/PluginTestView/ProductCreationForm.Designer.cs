
namespace PluginTestView
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitListBox = new System.Windows.Forms.ListBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(77, 16);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Название:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 33);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 22);
            this.nameTextBox.TabIndex = 1;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(13, 58);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(145, 16);
            this.unitLabel.TabIndex = 2;
            this.unitLabel.Text = "Единица измерения:";
            // 
            // unitListBox
            // 
            this.unitListBox.FormattingEnabled = true;
            this.unitListBox.ItemHeight = 16;
            this.unitListBox.Location = new System.Drawing.Point(16, 78);
            this.unitListBox.Name = "unitListBox";
            this.unitListBox.Size = new System.Drawing.Size(292, 84);
            this.unitListBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(13, 165);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 16);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Цена:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(16, 184);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(292, 22);
            this.priceTextBox.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(16, 213);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(292, 40);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Подтвердить";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ProductCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 271);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.unitListBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductCreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый продукт";
            this.Load += new System.EventHandler(this.ProductCreationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.ListBox unitListBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Button submitButton;
    }
}