namespace MessageDispatcher
{
    partial class FormService
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
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.ListBoxClients = new System.Windows.Forms.CheckedListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonNewSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(12, 12);
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(381, 20);
            this.textBoxContent.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(399, 12);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send text";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // ListBoxClients
            // 
            this.ListBoxClients.FormattingEnabled = true;
            this.ListBoxClients.Location = new System.Drawing.Point(13, 39);
            this.ListBoxClients.Name = "ListBoxClients";
            this.ListBoxClients.Size = new System.Drawing.Size(380, 124);
            this.ListBoxClients.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(399, 61);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonNewSet
            // 
            this.buttonNewSet.Location = new System.Drawing.Point(399, 102);
            this.buttonNewSet.Name = "buttonNewSet";
            this.buttonNewSet.Size = new System.Drawing.Size(75, 23);
            this.buttonNewSet.TabIndex = 4;
            this.buttonNewSet.Text = "Add new set";
            this.buttonNewSet.UseVisualStyleBackColor = true;
            this.buttonNewSet.Click += new System.EventHandler(this.buttonNewSet_Click);
            // 
            // FormService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 169);
            this.Controls.Add(this.buttonNewSet);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.ListBoxClients);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormService";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.CheckedListBox ListBoxClients;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonNewSet;
    }
}

