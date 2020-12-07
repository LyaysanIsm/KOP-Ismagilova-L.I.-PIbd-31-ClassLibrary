
namespace ChangerPlugin
{
    partial class ChangerForm
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
            this.enumListView = new System.Windows.Forms.ListView();
            this.enumValueName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.enumLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enumListView
            // 
            this.enumListView.AllowDrop = true;
            this.enumListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.enumValueName});
            this.enumListView.FullRowSelect = true;
            this.enumListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.enumListView.HideSelection = false;
            this.enumListView.Location = new System.Drawing.Point(11, 28);
            this.enumListView.MultiSelect = false;
            this.enumListView.Name = "enumListView";
            this.enumListView.Size = new System.Drawing.Size(255, 262);
            this.enumListView.TabIndex = 0;
            this.enumListView.UseCompatibleStateImageBehavior = false;
            this.enumListView.View = System.Windows.Forms.View.Details;
            this.enumListView.DragDrop += new System.Windows.Forms.DragEventHandler(this.EnumListView_DragDrop);
            this.enumListView.DragEnter += new System.Windows.Forms.DragEventHandler(this.EnumListView_DragEnter);
            // 
            // enumValueName
            // 
            this.enumValueName.Text = "Список значений";
            this.enumValueName.Width = 250;
            // 
            // enumLabel
            // 
            this.enumLabel.AutoSize = true;
            this.enumLabel.Location = new System.Drawing.Point(12, 9);
            this.enumLabel.Name = "enumLabel";
            this.enumLabel.Size = new System.Drawing.Size(186, 16);
            this.enumLabel.TabIndex = 1;
            this.enumLabel.Text = "Выберите новое значение:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(11, 296);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(255, 50);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ChangerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 358);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.enumLabel);
            this.Controls.Add(this.enumListView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение значения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView enumListView;
        private System.Windows.Forms.Label enumLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ColumnHeader enumValueName;
    }
}