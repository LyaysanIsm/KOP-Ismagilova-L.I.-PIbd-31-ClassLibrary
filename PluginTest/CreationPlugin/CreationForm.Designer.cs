
namespace CreationPlugin
{
    partial class CreationForm
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
            this.productLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.productTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(13, 13);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(67, 16);
            this.productLabel.TabIndex = 0;
            this.productLabel.Text = "Продукт:";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(13, 133);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(89, 16);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "Количество:";
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(16, 153);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(290, 22);
            this.countTextBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(16, 182);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(290, 49);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Подтвердить";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // productTextBox
            // 
            this.productTextBox.AllowDrop = true;
            this.productTextBox.Location = new System.Drawing.Point(16, 33);
            this.productTextBox.Multiline = true;
            this.productTextBox.Name = "productTextBox";
            this.productTextBox.ReadOnly = true;
            this.productTextBox.Size = new System.Drawing.Size(290, 97);
            this.productTextBox.TabIndex = 5;
            this.productTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.ProductTextBox_DragDrop);
            this.productTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.ProductTextBox_DragEnter);
            // 
            // CreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 249);
            this.Controls.Add(this.productTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.productLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая поставка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox productTextBox;
    }
}