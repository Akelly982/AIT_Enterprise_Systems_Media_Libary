
namespace ES_AitLibary_WindowsForms
{
    partial class StudentRecord
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
            this.ListBoxStudentRecord = new System.Windows.Forms.ListBox();
            this.panelNav.SuspendLayout();
            this.PanelBase.SuspendLayout();
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
            this.LabelStudentUsername.Location = new System.Drawing.Point(763, 99);
            this.LabelStudentUsername.Name = "LabelStudentUsername";
            this.LabelStudentUsername.Size = new System.Drawing.Size(107, 25);
            this.LabelStudentUsername.TabIndex = 4;
            this.LabelStudentUsername.Text = "undefined";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Record";
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
            this.PanelBase.Controls.Add(this.ListBoxStudentRecord);
            this.PanelBase.Location = new System.Drawing.Point(395, 216);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(835, 831);
            this.PanelBase.TabIndex = 2;
            // 
            // ListBoxStudentRecord
            // 
            this.ListBoxStudentRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxStudentRecord.FormattingEnabled = true;
            this.ListBoxStudentRecord.ItemHeight = 25;
            this.ListBoxStudentRecord.Items.AddRange(new object[] {
            "title - borrowDate - returnDate- acturalReturnDate - lateFee",
            "",
            "myMediaTitle - 7/2/2019 - 8/7/2019 - 8/7/2019 - null",
            "myMediaTitle - 7/2/2019 - 8/7/2019 - 8/7/2019 - null",
            "myMediaTitle - 7/2/2019 - 8/7/2019 - 10/7/2019 - $87",
            "myMediaTitle - 7/2/2019 - 8/7/2019 - 8/7/2019 - null",
            "myMediaTitle - 7/2/2019 - 8/7/2019 - 8/7/2019 - null",
            "myMediaTitle - 7/2/2019 - 8/7/2019 - 8/7/2019 - null",
            "etc",
            "etc"});
            this.ListBoxStudentRecord.Location = new System.Drawing.Point(57, 51);
            this.ListBoxStudentRecord.Name = "ListBoxStudentRecord";
            this.ListBoxStudentRecord.Size = new System.Drawing.Size(735, 729);
            this.ListBoxStudentRecord.TabIndex = 0;
            // 
            // StudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 1129);
            this.Controls.Add(this.PanelBase);
            this.Controls.Add(this.panelNav);
            this.Name = "StudentRecord";
            this.Text = "StudentRecord";
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.PanelBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label LabelStudentUsername;
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.ListBox ListBoxStudentRecord;
    }
}