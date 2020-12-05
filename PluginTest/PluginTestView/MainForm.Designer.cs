
namespace PluginTestView
{
    partial class MainForm
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
            this.productsListView = new System.Windows.Forms.ListView();
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productsLabel = new System.Windows.Forms.Label();
            this.supplyLabel = new System.Windows.Forms.Label();
            this.suppliesListView = new System.Windows.Forms.ListView();
            this.dateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newSupplyButton = new System.Windows.Forms.Button();
            this.invoiceButton = new System.Windows.Forms.Button();
            this.newProductButton = new System.Windows.Forms.Button();
            this.pluginsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pluginsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productsListView
            // 
            this.productsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.unitColumn,
            this.priceColumn});
            this.productsListView.FullRowSelect = true;
            this.productsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.productsListView.HideSelection = false;
            this.productsListView.Location = new System.Drawing.Point(11, 28);
            this.productsListView.MultiSelect = false;
            this.productsListView.Name = "productsListView";
            this.productsListView.Size = new System.Drawing.Size(476, 310);
            this.productsListView.TabIndex = 0;
            this.productsListView.UseCompatibleStateImageBehavior = false;
            this.productsListView.View = System.Windows.Forms.View.Details;
            this.productsListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.ProductsListView_ItemDrag);
            // 
            // nameColumn
            // 
            this.nameColumn.Text = "Название";
            this.nameColumn.Width = 200;
            // 
            // unitColumn
            // 
            this.unitColumn.Text = "Ед. измерения";
            this.unitColumn.Width = 120;
            // 
            // priceColumn
            // 
            this.priceColumn.Text = "Цена";
            this.priceColumn.Width = 150;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Location = new System.Drawing.Point(12, 9);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(131, 16);
            this.productsLabel.TabIndex = 1;
            this.productsLabel.Text = "Список продуктов:";
            // 
            // supplyLabel
            // 
            this.supplyLabel.AutoSize = true;
            this.supplyLabel.Location = new System.Drawing.Point(490, 9);
            this.supplyLabel.Name = "supplyLabel";
            this.supplyLabel.Size = new System.Drawing.Size(122, 16);
            this.supplyLabel.TabIndex = 2;
            this.supplyLabel.Text = "Список поставок:";
            // 
            // suppliesListView
            // 
            this.suppliesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dateColumn,
            this.productColumn,
            this.countColumn});
            this.suppliesListView.FullRowSelect = true;
            this.suppliesListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.suppliesListView.HideSelection = false;
            this.suppliesListView.Location = new System.Drawing.Point(493, 28);
            this.suppliesListView.MultiSelect = false;
            this.suppliesListView.Name = "suppliesListView";
            this.suppliesListView.Size = new System.Drawing.Size(476, 310);
            this.suppliesListView.TabIndex = 3;
            this.suppliesListView.UseCompatibleStateImageBehavior = false;
            this.suppliesListView.View = System.Windows.Forms.View.Details;
            // 
            // dateColumn
            // 
            this.dateColumn.Text = "Дата";
            this.dateColumn.Width = 150;
            // 
            // productColumn
            // 
            this.productColumn.Text = "Продукт";
            this.productColumn.Width = 200;
            // 
            // countColumn
            // 
            this.countColumn.Text = "Количество";
            this.countColumn.Width = 120;
            // 
            // newSupplyButton
            // 
            this.newSupplyButton.Location = new System.Drawing.Point(493, 344);
            this.newSupplyButton.Name = "newSupplyButton";
            this.newSupplyButton.Size = new System.Drawing.Size(280, 57);
            this.newSupplyButton.TabIndex = 5;
            this.newSupplyButton.Text = "Новая поставка";
            this.newSupplyButton.UseVisualStyleBackColor = true;
            // 
            // invoiceButton
            // 
            this.invoiceButton.Location = new System.Drawing.Point(779, 344);
            this.invoiceButton.Name = "invoiceButton";
            this.invoiceButton.Size = new System.Drawing.Size(187, 57);
            this.invoiceButton.TabIndex = 6;
            this.invoiceButton.Text = "Накладная";
            this.invoiceButton.UseVisualStyleBackColor = true;
            // 
            // newProductButton
            // 
            this.newProductButton.Location = new System.Drawing.Point(11, 344);
            this.newProductButton.Name = "newProductButton";
            this.newProductButton.Size = new System.Drawing.Size(476, 57);
            this.newProductButton.TabIndex = 8;
            this.newProductButton.Text = "Новый продукт";
            this.newProductButton.UseVisualStyleBackColor = true;
            this.newProductButton.Click += new System.EventHandler(this.NewProductButton_Click);
            // 
            // pluginsListView
            // 
            this.pluginsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.versionColumn});
            this.pluginsListView.FullRowSelect = true;
            this.pluginsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.pluginsListView.HideSelection = false;
            this.pluginsListView.Location = new System.Drawing.Point(11, 424);
            this.pluginsListView.Margin = new System.Windows.Forms.Padding(4);
            this.pluginsListView.MultiSelect = false;
            this.pluginsListView.Name = "pluginsListView";
            this.pluginsListView.Size = new System.Drawing.Size(506, 143);
            this.pluginsListView.TabIndex = 9;
            this.pluginsListView.UseCompatibleStateImageBehavior = false;
            this.pluginsListView.View = System.Windows.Forms.View.Details;
            this.pluginsListView.DoubleClick += new System.EventHandler(this.PluginsListView_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 402;
            // 
            // versionColumn
            // 
            this.versionColumn.Text = "Версия";
            this.versionColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.versionColumn.Width = 100;
            // 
            // pluginsLabel
            // 
            this.pluginsLabel.AutoSize = true;
            this.pluginsLabel.Location = new System.Drawing.Point(12, 404);
            this.pluginsLabel.Name = "pluginsLabel";
            this.pluginsLabel.Size = new System.Drawing.Size(222, 16);
            this.pluginsLabel.TabIndex = 10;
            this.pluginsLabel.Text = "Список подключенных плагинов:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 576);
            this.Controls.Add(this.pluginsLabel);
            this.Controls.Add(this.pluginsListView);
            this.Controls.Add(this.newProductButton);
            this.Controls.Add(this.invoiceButton);
            this.Controls.Add(this.newSupplyButton);
            this.Controls.Add(this.suppliesListView);
            this.Controls.Add(this.supplyLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productsListView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет продуктов";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView productsListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader unitColumn;
        private System.Windows.Forms.ColumnHeader priceColumn;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label supplyLabel;
        private System.Windows.Forms.ListView suppliesListView;
        private System.Windows.Forms.ColumnHeader dateColumn;
        private System.Windows.Forms.ColumnHeader productColumn;
        private System.Windows.Forms.ColumnHeader countColumn;
        private System.Windows.Forms.Button newSupplyButton;
        private System.Windows.Forms.Button invoiceButton;
        private System.Windows.Forms.Button newProductButton;
        private System.Windows.Forms.ListView pluginsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader versionColumn;
        private System.Windows.Forms.Label pluginsLabel;
    }
}