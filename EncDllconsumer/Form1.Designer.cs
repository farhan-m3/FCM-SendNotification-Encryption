namespace EncDllconsumer
{
    partial class Form1
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
            this.TxtText = new System.Windows.Forms.TextBox();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtText
            // 
            this.TxtText.Location = new System.Drawing.Point(130, 12);
            this.TxtText.Multiline = true;
            this.TxtText.Name = "TxtText";
            this.TxtText.Size = new System.Drawing.Size(370, 64);
            this.TxtText.TabIndex = 0;
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.Location = new System.Drawing.Point(130, 95);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(176, 40);
            this.BtnEncrypt.TabIndex = 1;
            this.BtnEncrypt.Text = "Encrypt Data";
            this.BtnEncrypt.UseVisualStyleBackColor = true;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Location = new System.Drawing.Point(326, 95);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(174, 40);
            this.BtnDecrypt.TabIndex = 2;
            this.BtnDecrypt.Text = "Decrypt Data";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 167);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.BtnEncrypt);
            this.Controls.Add(this.TxtText);
            this.Name = "Form1";
            this.Text = "Consumer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Button BtnDecrypt;
    }
}

