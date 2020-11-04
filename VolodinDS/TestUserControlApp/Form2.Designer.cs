namespace TestUserControlApp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.textBox = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.deserializeButton = new System.Windows.Forms.Button();
            this.pdfButton = new System.Windows.Forms.Button();
            this.wordButton = new System.Windows.Forms.Button();
            this.restoreFromBinary = new WindowsFormsComponentLibrary.RestoreFromBinary(this.components);
            this.tablePDF = new WindowsFormsComponentLibrary.TablePDF(this.components);
            this.wordDiagram = new WindowsFormsComponentLibrary.WordDiagram(this.components);
            this.saveWordDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(13, 13);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(290, 214);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "Работник:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = ".Zip архивы|*.zip";
            this.openFileDialog.Title = "Выберите .zip архив для десериализации";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "PDF файлы|*.pdf";
            this.saveFileDialog.Title = "Укажите путь для сохранения PDF файла";
            // 
            // deserializeButton
            // 
            this.deserializeButton.Location = new System.Drawing.Point(12, 233);
            this.deserializeButton.Name = "deserializeButton";
            this.deserializeButton.Size = new System.Drawing.Size(290, 60);
            this.deserializeButton.TabIndex = 1;
            this.deserializeButton.Text = "Десериализация";
            this.deserializeButton.UseVisualStyleBackColor = true;
            this.deserializeButton.Click += new System.EventHandler(this.DeserializeButton_Click);
            // 
            // pdfButton
            // 
            this.pdfButton.Location = new System.Drawing.Point(12, 299);
            this.pdfButton.Name = "pdfButton";
            this.pdfButton.Size = new System.Drawing.Size(290, 60);
            this.pdfButton.TabIndex = 2;
            this.pdfButton.Text = "PDF";
            this.pdfButton.UseVisualStyleBackColor = true;
            this.pdfButton.Click += new System.EventHandler(this.PdfButton_Click);
            // 
            // wordButton
            // 
            this.wordButton.Location = new System.Drawing.Point(12, 365);
            this.wordButton.Name = "wordButton";
            this.wordButton.Size = new System.Drawing.Size(290, 60);
            this.wordButton.TabIndex = 3;
            this.wordButton.Text = "WORD";
            this.wordButton.UseVisualStyleBackColor = true;
            this.wordButton.Click += new System.EventHandler(this.WordButton_Click);
            // 
            // saveWordDialog
            // 
            this.saveWordDialog.Filter = "Файлы Word|*.docx";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 437);
            this.Controls.Add(this.wordButton);
            this.Controls.Add(this.pdfButton);
            this.Controls.Add(this.deserializeButton);
            this.Controls.Add(this.textBox);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private WindowsFormsComponentLibrary.RestoreFromBinary restoreFromBinary;
        private WindowsFormsComponentLibrary.TablePDF tablePDF;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button deserializeButton;
        private System.Windows.Forms.Button pdfButton;
        private System.Windows.Forms.Button wordButton;
        private WindowsFormsComponentLibrary.WordDiagram wordDiagram;
        private System.Windows.Forms.SaveFileDialog saveWordDialog;
    }
}