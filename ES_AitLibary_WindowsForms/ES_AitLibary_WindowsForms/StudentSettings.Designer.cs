
namespace ES_AitLibary_WindowsForms
{
    partial class StudentSettings
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.LabelStudentUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBack = new System.Windows.Forms.Button();
            this.PanelBase = new System.Windows.Forms.Panel();
            this.PanelAdmin = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChkBoxDelete = new System.Windows.Forms.CheckBox();
            this.BtnAdminDelete = new System.Windows.Forms.Button();
            this.BtnAdminResetPassword = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelStudent = new System.Windows.Forms.Panel();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxPhone = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.TextBoxPasswordRetype = new System.Windows.Forms.TextBox();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNav.SuspendLayout();
            this.PanelBase.SuspendLayout();
            this.PanelAdmin.SuspendLayout();
            this.PanelStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelNav.Controls.Add(this.LabelStudentUsername);
            this.panelNav.Controls.Add(this.label1);
            this.panelNav.Controls.Add(this.BtnBack);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1674, 164);
            this.panelNav.TabIndex = 1;
            // 
            // LabelStudentUsername
            // 
            this.LabelStudentUsername.AutoSize = true;
            this.LabelStudentUsername.Location = new System.Drawing.Point(803, 110);
            this.LabelStudentUsername.Name = "LabelStudentUsername";
            this.LabelStudentUsername.Size = new System.Drawing.Size(107, 25);
            this.LabelStudentUsername.TabIndex = 3;
            this.LabelStudentUsername.Text = "undefined";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(733, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Settings";
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(35, 31);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(188, 104);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "<";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // PanelBase
            // 
            this.PanelBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelBase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelBase.Controls.Add(this.PanelAdmin);
            this.PanelBase.Controls.Add(this.PanelStudent);
            this.PanelBase.Location = new System.Drawing.Point(468, 185);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(771, 913);
            this.PanelBase.TabIndex = 2;
            // 
            // PanelAdmin
            // 
            this.PanelAdmin.Controls.Add(this.textBox1);
            this.PanelAdmin.Controls.Add(this.ChkBoxDelete);
            this.PanelAdmin.Controls.Add(this.BtnAdminDelete);
            this.PanelAdmin.Controls.Add(this.BtnAdminResetPassword);
            this.PanelAdmin.Controls.Add(this.label3);
            this.PanelAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelAdmin.Location = new System.Drawing.Point(0, 465);
            this.PanelAdmin.Name = "PanelAdmin";
            this.PanelAdmin.Size = new System.Drawing.Size(771, 354);
            this.PanelAdmin.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 31);
            this.textBox1.TabIndex = 4;
            // 
            // ChkBoxDelete
            // 
            this.ChkBoxDelete.AutoSize = true;
            this.ChkBoxDelete.Location = new System.Drawing.Point(545, 268);
            this.ChkBoxDelete.Name = "ChkBoxDelete";
            this.ChkBoxDelete.Size = new System.Drawing.Size(103, 29);
            this.ChkBoxDelete.TabIndex = 3;
            this.ChkBoxDelete.Text = "delete";
            this.ChkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // BtnAdminDelete
            // 
            this.BtnAdminDelete.Location = new System.Drawing.Point(274, 241);
            this.BtnAdminDelete.Name = "BtnAdminDelete";
            this.BtnAdminDelete.Size = new System.Drawing.Size(227, 76);
            this.BtnAdminDelete.TabIndex = 2;
            this.BtnAdminDelete.Text = "Delete";
            this.BtnAdminDelete.UseVisualStyleBackColor = true;
            // 
            // BtnAdminResetPassword
            // 
            this.BtnAdminResetPassword.Location = new System.Drawing.Point(272, 134);
            this.BtnAdminResetPassword.Name = "BtnAdminResetPassword";
            this.BtnAdminResetPassword.Size = new System.Drawing.Size(231, 76);
            this.BtnAdminResetPassword.TabIndex = 1;
            this.BtnAdminResetPassword.Text = "Reset Password";
            this.BtnAdminResetPassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Admin";
            // 
            // PanelStudent
            // 
            this.PanelStudent.Controls.Add(this.TextBoxEmail);
            this.PanelStudent.Controls.Add(this.TextBoxPhone);
            this.PanelStudent.Controls.Add(this.TextBoxPassword);
            this.PanelStudent.Controls.Add(this.TextBoxPasswordRetype);
            this.PanelStudent.Controls.Add(this.BtnSaveChanges);
            this.PanelStudent.Controls.Add(this.label7);
            this.PanelStudent.Controls.Add(this.label6);
            this.PanelStudent.Controls.Add(this.label5);
            this.PanelStudent.Controls.Add(this.label4);
            this.PanelStudent.Controls.Add(this.label2);
            this.PanelStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelStudent.Location = new System.Drawing.Point(0, 0);
            this.PanelStudent.Name = "PanelStudent";
            this.PanelStudent.Size = new System.Drawing.Size(771, 465);
            this.PanelStudent.TabIndex = 0;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(257, 104);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(261, 31);
            this.TextBoxEmail.TabIndex = 8;
            // 
            // TextBoxPhone
            // 
            this.TextBoxPhone.Location = new System.Drawing.Point(257, 170);
            this.TextBoxPhone.Name = "TextBoxPhone";
            this.TextBoxPhone.Size = new System.Drawing.Size(261, 31);
            this.TextBoxPhone.TabIndex = 7;
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(257, 245);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(261, 31);
            this.TextBoxPassword.TabIndex = 6;
            // 
            // TextBoxPasswordRetype
            // 
            this.TextBoxPasswordRetype.Location = new System.Drawing.Point(257, 323);
            this.TextBoxPasswordRetype.Name = "TextBoxPasswordRetype";
            this.TextBoxPasswordRetype.Size = new System.Drawing.Size(261, 31);
            this.TextBoxPasswordRetype.TabIndex = 5;
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Location = new System.Drawing.Point(272, 389);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(246, 70);
            this.BtnSaveChanges.TabIndex = 5;
            this.BtnSaveChanges.Text = "Save Changes";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Retype Password:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(155, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student";
            // 
            // StudentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.PanelBase);
            this.Controls.Add(this.panelNav);
            this.Name = "StudentSettings";
            this.Text = "StudentSettings";
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.PanelBase.ResumeLayout(false);
            this.PanelAdmin.ResumeLayout(false);
            this.PanelAdmin.PerformLayout();
            this.PanelStudent.ResumeLayout(false);
            this.PanelStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelStudentUsername;
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.Panel PanelAdmin;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ChkBoxDelete;
        private System.Windows.Forms.Button BtnAdminDelete;
        private System.Windows.Forms.Button BtnAdminResetPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelStudent;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPhone;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.TextBox TextBoxPasswordRetype;
        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}