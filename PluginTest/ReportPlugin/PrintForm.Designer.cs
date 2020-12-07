
namespace ReportPlugin
{
    partial class PrintForm
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
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.reportPreview = new System.Windows.Forms.PrintPreviewControl();
            this.label1 = new System.Windows.Forms.Label();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDocument
            // 
            this.printDocument.DocumentName = "report";
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument_PrintPage);
            // 
            // reportPreview
            // 
            this.reportPreview.AutoZoom = false;
            this.reportPreview.Document = this.printDocument;
            this.reportPreview.Location = new System.Drawing.Point(12, 38);
            this.reportPreview.Name = "reportPreview";
            this.reportPreview.Size = new System.Drawing.Size(403, 564);
            this.reportPreview.TabIndex = 0;
            this.reportPreview.Zoom = 0.48246674727932287D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Предпросмотр:";
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(12, 608);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(403, 35);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Печать";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 656);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportPreview);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Печать накладной";
            this.Load += new System.EventHandler(this.PrintForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintPreviewControl reportPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button printButton;
    }
}