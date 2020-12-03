
namespace ApplicationView
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productManufacturerCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appleButton = new System.Windows.Forms.Button();
            this.samsungButton = new System.Windows.Forms.Button();
            this.xiaomiButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.deliveryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AllowUserToResizeColumns = false;
            this.productGridView.AllowUserToResizeRows = false;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productName,
            this.productPrice,
            this.productManufacturerName,
            this.productManufacturerCountry});
            this.productGridView.Location = new System.Drawing.Point(17, 16);
            this.productGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.RowHeadersWidth = 62;
            this.productGridView.RowTemplate.Height = 28;
            this.productGridView.Size = new System.Drawing.Size(1034, 560);
            this.productGridView.TabIndex = 0;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productName.HeaderText = "Модель";
            this.productName.MinimumWidth = 8;
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Цена";
            this.productPrice.MinimumWidth = 8;
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Width = 150;
            // 
            // productManufacturerName
            // 
            this.productManufacturerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.productManufacturerName.HeaderText = "Производитель";
            this.productManufacturerName.MinimumWidth = 8;
            this.productManufacturerName.Name = "productManufacturerName";
            this.productManufacturerName.ReadOnly = true;
            this.productManufacturerName.Width = 195;
            // 
            // productManufacturerCountry
            // 
            this.productManufacturerCountry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productManufacturerCountry.HeaderText = "Страна производства";
            this.productManufacturerCountry.MinimumWidth = 8;
            this.productManufacturerCountry.Name = "productManufacturerCountry";
            this.productManufacturerCountry.ReadOnly = true;
            // 
            // appleButton
            // 
            this.appleButton.Location = new System.Drawing.Point(1059, 16);
            this.appleButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.appleButton.Name = "appleButton";
            this.appleButton.Size = new System.Drawing.Size(321, 81);
            this.appleButton.TabIndex = 1;
            this.appleButton.Text = "Смартфон Apple";
            this.appleButton.UseVisualStyleBackColor = true;
            this.appleButton.Click += new System.EventHandler(this.AppleButton_Click);
            // 
            // samsungButton
            // 
            this.samsungButton.Location = new System.Drawing.Point(1059, 105);
            this.samsungButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.samsungButton.Name = "samsungButton";
            this.samsungButton.Size = new System.Drawing.Size(321, 81);
            this.samsungButton.TabIndex = 2;
            this.samsungButton.Text = "Смартфон Samsung";
            this.samsungButton.UseVisualStyleBackColor = true;
            this.samsungButton.Click += new System.EventHandler(this.SamsungButton_Click);
            // 
            // xiaomiButton
            // 
            this.xiaomiButton.Location = new System.Drawing.Point(1059, 194);
            this.xiaomiButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.xiaomiButton.Name = "xiaomiButton";
            this.xiaomiButton.Size = new System.Drawing.Size(321, 81);
            this.xiaomiButton.TabIndex = 3;
            this.xiaomiButton.Text = "Смартфон Xiaomi";
            this.xiaomiButton.UseVisualStyleBackColor = true;
            this.xiaomiButton.Click += new System.EventHandler(this.XiaomiButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(1062, 495);
            this.ordersButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(321, 81);
            this.ordersButton.TabIndex = 4;
            this.ordersButton.Text = "Посмотреть заказы";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // deliveryButton
            // 
            this.deliveryButton.Location = new System.Drawing.Point(1062, 408);
            this.deliveryButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deliveryButton.Name = "deliveryButton";
            this.deliveryButton.Size = new System.Drawing.Size(321, 81);
            this.deliveryButton.TabIndex = 5;
            this.deliveryButton.Text = "Заказать доставку";
            this.deliveryButton.UseVisualStyleBackColor = true;
            this.deliveryButton.Click += new System.EventHandler(this.DeliveryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 588);
            this.Controls.Add(this.deliveryButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.xiaomiButton);
            this.Controls.Add(this.samsungButton);
            this.Controls.Add(this.appleButton);
            this.Controls.Add(this.productGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смартфоны";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Button appleButton;
        private System.Windows.Forms.Button samsungButton;
        private System.Windows.Forms.Button xiaomiButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productManufacturerCountry;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button deliveryButton;
    }
}

