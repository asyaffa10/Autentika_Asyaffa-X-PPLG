using System;

namespace SchoolAppRegister
{
    partial class FormRegister
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
            this.btnSubmitRegister = new System.Windows.Forms.Button();
            this.btnNavToLogin = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Register";
            // 
            // btnSubmitRegister
            // 
            this.btnSubmitRegister.Location = new System.Drawing.Point(240, 339);
            this.btnSubmitRegister.Name = "btnSubmitRegister";
            this.btnSubmitRegister.Size = new System.Drawing.Size(168, 36);
            this.btnSubmitRegister.TabIndex = 1;
            this.btnSubmitRegister.Text = "Register";
            this.btnSubmitRegister.UseVisualStyleBackColor = true;
            this.btnSubmitRegister.Click += new System.EventHandler(this.btnSubmitRegister_Click);
            // 
            // btnNavToLogin
            // 
            this.btnNavToLogin.Location = new System.Drawing.Point(240, 402);
            this.btnNavToLogin.Name = "btnNavToLogin";
            this.btnNavToLogin.Size = new System.Drawing.Size(168, 36);
            this.btnNavToLogin.TabIndex = 2;
            this.btnNavToLogin.Text = "To Login";
            this.btnNavToLogin.UseVisualStyleBackColor = true;
            this.btnNavToLogin.Click += new System.EventHandler(this.btnNavToLogin_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(221, 112);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(223, 45);
            this.txtFullName.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(221, 183);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(223, 45);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(221, 265);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 45);
            this.txtPassword.TabIndex = 5;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnNavToLogin);
            this.Controls.Add(this.btnSubmitRegister);
            this.Controls.Add(this.label1);
            this.Name = "FormRegister";
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmitRegister;
        private System.Windows.Forms.Button btnNavToLogin;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
    }
}