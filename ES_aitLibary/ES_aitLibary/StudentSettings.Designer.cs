
namespace ES_aitLibary
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.labelStudentNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelAdminStudentSettings = new System.Windows.Forms.Panel();
            this.checkBoxDeleteErrorProtection = new System.Windows.Forms.CheckBox();
            this.textBoxAdminResetPassword = new System.Windows.Forms.TextBox();
            this.btnAdminResetPassword = new System.Windows.Forms.Button();
            this.btnAdminDeleteStudent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.textBoxStudentPassword2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStudentPassword1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxStudentPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSaveChangesStudent = new System.Windows.Forms.Button();
            this.textBoxStudentEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelAdminStudentSettings.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnReturn);
            this.panel1.Controls.Add(this.labelStudentNumber);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1974, 173);
            this.panel1.TabIndex = 2;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.Location = new System.Drawing.Point(34, 30);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(189, 111);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "<";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // labelStudentNumber
            // 
            this.labelStudentNumber.AutoSize = true;
            this.labelStudentNumber.Location = new System.Drawing.Point(956, 109);
            this.labelStudentNumber.Name = "labelStudentNumber";
            this.labelStudentNumber.Size = new System.Drawing.Size(66, 32);
            this.labelStudentNumber.TabIndex = 1;
            this.labelStudentNumber.Text = "1234";
            this.labelStudentNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStudentNumber.Click += new System.EventHandler(this.labelStudentNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(871, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Settings";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panelAdminStudentSettings);
            this.panel2.Controls.Add(this.panelStudent);
            this.panel2.Location = new System.Drawing.Point(636, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 954);
            this.panel2.TabIndex = 4;
            // 
            // panelAdminStudentSettings
            // 
            this.panelAdminStudentSettings.Controls.Add(this.checkBoxDeleteErrorProtection);
            this.panelAdminStudentSettings.Controls.Add(this.textBoxAdminResetPassword);
            this.panelAdminStudentSettings.Controls.Add(this.btnAdminResetPassword);
            this.panelAdminStudentSettings.Controls.Add(this.btnAdminDeleteStudent);
            this.panelAdminStudentSettings.Controls.Add(this.label3);
            this.panelAdminStudentSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdminStudentSettings.Location = new System.Drawing.Point(0, 608);
            this.panelAdminStudentSettings.Name = "panelAdminStudentSettings";
            this.panelAdminStudentSettings.Size = new System.Drawing.Size(754, 305);
            this.panelAdminStudentSettings.TabIndex = 1;
            // 
            // checkBoxDeleteErrorProtection
            // 
            this.checkBoxDeleteErrorProtection.AutoSize = true;
            this.checkBoxDeleteErrorProtection.Location = new System.Drawing.Point(539, 226);
            this.checkBoxDeleteErrorProtection.Name = "checkBoxDeleteErrorProtection";
            this.checkBoxDeleteErrorProtection.Size = new System.Drawing.Size(127, 36);
            this.checkBoxDeleteErrorProtection.TabIndex = 5;
            this.checkBoxDeleteErrorProtection.Text = "Delete?";
            this.checkBoxDeleteErrorProtection.UseVisualStyleBackColor = true;
            // 
            // textBoxAdminResetPassword
            // 
            this.textBoxAdminResetPassword.Location = new System.Drawing.Point(279, 38);
            this.textBoxAdminResetPassword.Name = "textBoxAdminResetPassword";
            this.textBoxAdminResetPassword.Size = new System.Drawing.Size(246, 39);
            this.textBoxAdminResetPassword.TabIndex = 4;
            // 
            // btnAdminResetPassword
            // 
            this.btnAdminResetPassword.Location = new System.Drawing.Point(279, 83);
            this.btnAdminResetPassword.Name = "btnAdminResetPassword";
            this.btnAdminResetPassword.Size = new System.Drawing.Size(246, 74);
            this.btnAdminResetPassword.TabIndex = 2;
            this.btnAdminResetPassword.Text = "Reset password";
            this.btnAdminResetPassword.UseVisualStyleBackColor = true;
            this.btnAdminResetPassword.Click += new System.EventHandler(this.btnAdminResetPassword_Click);
            // 
            // btnAdminDeleteStudent
            // 
            this.btnAdminDeleteStudent.Location = new System.Drawing.Point(279, 197);
            this.btnAdminDeleteStudent.Name = "btnAdminDeleteStudent";
            this.btnAdminDeleteStudent.Size = new System.Drawing.Size(240, 94);
            this.btnAdminDeleteStudent.TabIndex = 1;
            this.btnAdminDeleteStudent.Text = "Delete Student";
            this.btnAdminDeleteStudent.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "admin";
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.textBoxStudentPassword2);
            this.panelStudent.Controls.Add(this.label8);
            this.panelStudent.Controls.Add(this.textBoxStudentPassword1);
            this.panelStudent.Controls.Add(this.label6);
            this.panelStudent.Controls.Add(this.textBoxStudentPhoneNumber);
            this.panelStudent.Controls.Add(this.btnSaveChangesStudent);
            this.panelStudent.Controls.Add(this.textBoxStudentEmail);
            this.panelStudent.Controls.Add(this.label5);
            this.panelStudent.Controls.Add(this.label4);
            this.panelStudent.Controls.Add(this.label2);
            this.panelStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudent.Location = new System.Drawing.Point(0, 0);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(754, 608);
            this.panelStudent.TabIndex = 0;
            // 
            // textBoxStudentPassword2
            // 
            this.textBoxStudentPassword2.Location = new System.Drawing.Point(279, 350);
            this.textBoxStudentPassword2.Name = "textBoxStudentPassword2";
            this.textBoxStudentPassword2.Size = new System.Drawing.Size(309, 39);
            this.textBoxStudentPassword2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Retype password:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStudentPassword1
            // 
            this.textBoxStudentPassword1.Location = new System.Drawing.Point(279, 266);
            this.textBoxStudentPassword1.Name = "textBoxStudentPassword1";
            this.textBoxStudentPassword1.Size = new System.Drawing.Size(309, 39);
            this.textBoxStudentPassword1.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(117, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 32);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxStudentPhoneNumber
            // 
            this.textBoxStudentPhoneNumber.Location = new System.Drawing.Point(279, 179);
            this.textBoxStudentPhoneNumber.Name = "textBoxStudentPhoneNumber";
            this.textBoxStudentPhoneNumber.Size = new System.Drawing.Size(309, 39);
            this.textBoxStudentPhoneNumber.TabIndex = 5;
            // 
            // btnSaveChangesStudent
            // 
            this.btnSaveChangesStudent.Location = new System.Drawing.Point(279, 465);
            this.btnSaveChangesStudent.Name = "btnSaveChangesStudent";
            this.btnSaveChangesStudent.Size = new System.Drawing.Size(256, 66);
            this.btnSaveChangesStudent.TabIndex = 4;
            this.btnSaveChangesStudent.Text = "SaveChanges";
            this.btnSaveChangesStudent.UseVisualStyleBackColor = true;
            // 
            // textBoxStudentEmail
            // 
            this.textBoxStudentEmail.Location = new System.Drawing.Point(279, 95);
            this.textBoxStudentEmail.Name = "textBoxStudentEmail";
            this.textBoxStudentEmail.Size = new System.Drawing.Size(309, 39);
            this.textBoxStudentEmail.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Phone:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "student";
            // 
            // StudentSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1974, 1229);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentSettings";
            this.Text = "StudentSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelAdminStudentSettings.ResumeLayout(false);
            this.panelAdminStudentSettings.PerformLayout();
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label labelStudentNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelAdminStudentSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.TextBox textBoxStudentPassword2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxStudentPassword1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxStudentPhoneNumber;
        private System.Windows.Forms.Button btnSaveChangesStudent;
        private System.Windows.Forms.TextBox textBoxStudentEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdminResetPassword;
        private System.Windows.Forms.Button btnAdminResetPassword;
        private System.Windows.Forms.Button btnAdminDeleteStudent;
        private System.Windows.Forms.CheckBox checkBoxDeleteErrorProtection;
    }
}