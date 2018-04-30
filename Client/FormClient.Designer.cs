namespace Client
{
    partial class FormClient
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.richTextBoxContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // richTextBoxContent
            // 
            this.richTextBoxContent.Location = new System.Drawing.Point(12, 42);
            this.richTextBoxContent.Name = "richTextBoxContent";
            this.richTextBoxContent.ReadOnly = true;
            this.richTextBoxContent.Size = new System.Drawing.Size(216, 164);
            this.richTextBoxContent.TabIndex = 1;
            this.richTextBoxContent.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 223);
            this.Controls.Add(this.richTextBoxContent);
            this.Controls.Add(this.buttonLogin);
            this.Name = "Form1";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        internal System.Windows.Forms.RichTextBox richTextBoxContent;
    }
}

