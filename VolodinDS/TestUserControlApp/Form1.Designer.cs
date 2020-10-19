namespace TestUserControlApp
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.getTextButton = new System.Windows.Forms.Button();
            this.treeViewControl = new WindowsFormsControlLibrary.TreeViewControl();
            this.textBoxUserControl = new WindowsFormsControlLibrary.TextBoxUserControl();
            this.checkedListControl = new WindowsFormsControlLibrary.CheckedListControl();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(349, 408);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(344, 40);
            this.inputTextBox.TabIndex = 2;
            // 
            // getTextButton
            // 
            this.getTextButton.Location = new System.Drawing.Point(349, 362);
            this.getTextButton.Name = "getTextButton";
            this.getTextButton.Size = new System.Drawing.Size(344, 40);
            this.getTextButton.TabIndex = 3;
            this.getTextButton.Text = "Получить текст";
            this.getTextButton.UseVisualStyleBackColor = true;
            this.getTextButton.Click += new System.EventHandler(this.GetTextButton_Click);
            // 
            // treeViewControl
            // 
            this.treeViewControl.Location = new System.Drawing.Point(25, 226);
            this.treeViewControl.Name = "treeViewControl";
            this.treeViewControl.Size = new System.Drawing.Size(307, 309);
            this.treeViewControl.TabIndex = 4;
            // 
            // textBoxUserControl
            // 
            this.textBoxUserControl.Location = new System.Drawing.Point(338, 295);
            this.textBoxUserControl.Name = "textBoxUserControl";
            this.textBoxUserControl.Size = new System.Drawing.Size(368, 61);
            this.textBoxUserControl.TabIndex = 1;
            // 
            // checkedListControl
            // 
            this.checkedListControl.Location = new System.Drawing.Point(13, 13);
            this.checkedListControl.Name = "checkedListControl";
            this.checkedListControl.Size = new System.Drawing.Size(333, 207);
            this.checkedListControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 555);
            this.Controls.Add(this.treeViewControl);
            this.Controls.Add(this.getTextButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.textBoxUserControl);
            this.Controls.Add(this.checkedListControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary.CheckedListControl checkedListControl;
        private WindowsFormsControlLibrary.TextBoxUserControl textBoxUserControl;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button getTextButton;
        private WindowsFormsControlLibrary.TreeViewControl treeViewControl;
    }
}

