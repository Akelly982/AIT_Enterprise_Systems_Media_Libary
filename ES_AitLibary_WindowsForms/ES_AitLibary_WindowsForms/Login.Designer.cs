﻿
namespace ES_AitLibary_WindowsForms
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.BtnForgotPassword = new System.Windows.Forms.Button();
            this.BtnLoggin = new System.Windows.Forms.Button();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnCheatLoggin = new System.Windows.Forms.Button();
            this.ChkBoxIsAdminCheat = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.TextBoxPassword);
            this.panel1.Controls.Add(this.TextBoxUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.BtnCheatLoggin);
            this.panel1.Controls.Add(this.ChkBoxIsAdminCheat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(594, 264);
            this.panel1.MaximumSize = new System.Drawing.Size(800, 650);
            this.panel1.MinimumSize = new System.Drawing.Size(800, 650);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 650);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnSignUp);
            this.panel2.Controls.Add(this.BtnForgotPassword);
            this.panel2.Controls.Add(this.BtnLoggin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 471);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 179);
            this.panel2.TabIndex = 8;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(419, 105);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(268, 50);
            this.BtnSignUp.TabIndex = 2;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseVisualStyleBackColor = true;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // BtnForgotPassword
            // 
            this.BtnForgotPassword.Location = new System.Drawing.Point(111, 105);
            this.BtnForgotPassword.Name = "BtnForgotPassword";
            this.BtnForgotPassword.Size = new System.Drawing.Size(268, 50);
            this.BtnForgotPassword.TabIndex = 1;
            this.BtnForgotPassword.Text = "Forgot Password";
            this.BtnForgotPassword.UseVisualStyleBackColor = true;
            this.BtnForgotPassword.Click += new System.EventHandler(this.BtnForgotPassword_Click);
            // 
            // BtnLoggin
            // 
            this.BtnLoggin.Location = new System.Drawing.Point(111, 29);
            this.BtnLoggin.Name = "BtnLoggin";
            this.BtnLoggin.Size = new System.Drawing.Size(576, 50);
            this.BtnLoggin.TabIndex = 0;
            this.BtnLoggin.Text = "Login";
            this.BtnLoggin.UseVisualStyleBackColor = true;
            this.BtnLoggin.Click += new System.EventHandler(this.BtnLoggin_Click);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(261, 346);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(375, 31);
            this.TextBoxPassword.TabIndex = 7;
            this.TextBoxPassword.TextChanged += new System.EventHandler(this.TextBoxPassword_TextChanged);
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(261, 294);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(375, 31);
            this.TextBoxUsername.TabIndex = 6;
            this.TextBoxUsername.TextChanged += new System.EventHandler(this.TextBoxUsername_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username:";
            // 
            // BtnCheatLoggin
            // 
            this.BtnCheatLoggin.Location = new System.Drawing.Point(586, 31);
            this.BtnCheatLoggin.Name = "BtnCheatLoggin";
            this.BtnCheatLoggin.Size = new System.Drawing.Size(188, 36);
            this.BtnCheatLoggin.TabIndex = 3;
            this.BtnCheatLoggin.Text = "Login Cheat";
            this.BtnCheatLoggin.UseVisualStyleBackColor = true;
            this.BtnCheatLoggin.Click += new System.EventHandler(this.BtnCheatLoggin_Click);
            // 
            // ChkBoxIsAdminCheat
            // 
            this.ChkBoxIsAdminCheat.AutoSize = true;
            this.ChkBoxIsAdminCheat.Location = new System.Drawing.Point(289, 39);
            this.ChkBoxIsAdminCheat.Name = "ChkBoxIsAdminCheat";
            this.ChkBoxIsAdminCheat.Size = new System.Drawing.Size(250, 29);
            this.ChkBoxIsAdminCheat.TabIndex = 2;
            this.ChkBoxIsAdminCheat.Text = "админ (administrada)";
            this.ChkBoxIsAdminCheat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "AIT Libary";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::ES_AitLibary_WindowsForms.Properties.Resources.ait;
            this.pictureBox1.Location = new System.Drawing.Point(29, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1229);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Button BtnForgotPassword;
        private System.Windows.Forms.Button BtnLoggin;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCheatLoggin;
        private System.Windows.Forms.CheckBox ChkBoxIsAdminCheat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

