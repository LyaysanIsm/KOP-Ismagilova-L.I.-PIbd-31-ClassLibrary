
namespace ApplicationView
{
    partial class OrdersForm
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
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersGridView
            // 
            this.ordersGridView.AllowUserToAddRows = false;
            this.ordersGridView.AllowUserToDeleteRows = false;
            this.ordersGridView.AllowUserToResizeColumns = false;
            this.ordersGridView.AllowUserToResizeRows = false;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdName,
            this.Count,
            this.Delivery});
            this.ordersGridView.Location = new System.Drawing.Point(13, 13);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.RowHeadersVisible = false;
            this.ordersGridView.RowHeadersWidth = 62;
            this.ordersGridView.RowTemplate.Height = 28;
            this.ordersGridView.Size = new System.Drawing.Size(1366, 454);
            this.ordersGridView.TabIndex = 0;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(13, 473);
            this.newOrderButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(321, 81);
            this.newOrderButton.TabIndex = 2;
            this.newOrderButton.Text = "Новый заказ";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // ProdName
            // 
            this.ProdName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProdName.FillWeight = 30F;
            this.ProdName.HeaderText = "Продукт";
            this.ProdName.MinimumWidth = 8;
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            // 
            // Count
            // 
            this.Count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Count.FillWeight = 10F;
            this.Count.HeaderText = "Количество";
            this.Count.MinimumWidth = 8;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            // 
            // Delivery
            // 
            this.Delivery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Delivery.FillWeight = 60F;
            this.Delivery.HeaderText = "Информация о доставке";
            this.Delivery.MinimumWidth = 8;
            this.Delivery.Name = "Delivery";
            this.Delivery.ReadOnly = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 563);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.ordersGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список заказов";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delivery;
    }
}