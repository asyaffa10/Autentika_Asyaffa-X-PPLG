namespace SchoolAppRegister
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSumbitLogin = new System.Windows.Forms.Button();
            this.btnNavToRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Login";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(253, 100);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(198, 45);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(253, 186);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(198, 45);
            this.txtPassword.TabIndex = 2;
            // 
            // btnSumbitLogin
            // 
            this.btnSumbitLogin.Location = new System.Drawing.Point(267, 265);
            this.btnSumbitLogin.Name = "btnSumbitLogin";
            this.btnSumbitLogin.Size = new System.Drawing.Size(165, 44);
            this.btnSumbitLogin.TabIndex = 3;
            this.btnSumbitLogin.Text = "Login";
            this.btnSumbitLogin.UseVisualStyleBackColor = true;
            this.btnSumbitLogin.Click += new System.EventHandler(this.btnSumbitLogin_Click);
            // 
            // btnNavToRegister
            // 
            this.btnNavToRegister.Location = new System.Drawing.Point(267, 335);
            this.btnNavToRegister.Name = "btnNavToRegister";
            this.btnNavToRegister.Size = new System.Drawing.Size(165, 53);
            this.btnNavToRegister.TabIndex = 4;
            this.btnNavToRegister.Text = "To Register";
            this.btnNavToRegister.UseVisualStyleBackColor = true;
            this.btnNavToRegister.Click += new System.EventHandler(this.btnNavToRegister_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNavToRegister);
            this.Controls.Add(this.btnSumbitLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSumbitLogin;
        private System.Windows.Forms.Button btnNavToRegister;
    }
}