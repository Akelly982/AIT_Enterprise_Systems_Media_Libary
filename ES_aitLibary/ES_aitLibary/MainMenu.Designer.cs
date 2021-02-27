
namespace ES_aitLibary
{
    partial class MainMenu
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelUserHeaderData = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelStudentDataRow = new System.Windows.Forms.Panel();
            this.panelFillStudentBtns = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStudentActivity = new System.Windows.Forms.Button();
            this.btnStudentSettings = new System.Windows.Forms.Button();
            this.btnStudentRecords = new System.Windows.Forms.Button();
            this.panelAdminStudentData = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdminStudentNumber = new System.Windows.Forms.TextBox();
            this.panelStudentData = new System.Windows.Forms.Panel();
            this.labelStudentNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelStudentDataRow.SuspendLayout();
            this.panelFillStudentBtns.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelAdminStudentData.SuspendLayout();
            this.panelStudentData.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.labelUserHeaderData);
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1795, 150);
            this.panelHeader.TabIndex = 0;
            // 
            // labelUserHeaderData
            // 
            this.labelUserHeaderData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserHeaderData.AutoSize = true;
            this.labelUserHeaderData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUserHeaderData.Location = new System.Drawing.Point(1425, 52);
            this.labelUserHeaderData.Name = "labelUserHeaderData";
            this.labelUserHeaderData.Size = new System.Drawing.Size(340, 45);
            this.labelUserHeaderData.TabIndex = 2;
            this.labelUserHeaderData.Text = "undefined - frank west";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 111);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(807, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Menu";
            // 
            // panelStudentDataRow
            // 
            this.panelStudentDataRow.Controls.Add(this.panelFillStudentBtns);
            this.panelStudentDataRow.Controls.Add(this.panelAdminStudentData);
            this.panelStudentDataRow.Controls.Add(this.panelStudentData);
            this.panelStudentDataRow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentDataRow.Location = new System.Drawing.Point(0, 150);
            this.panelStudentDataRow.Name = "panelStudentDataRow";
            this.panelStudentDataRow.Size = new System.Drawing.Size(1795, 277);
            this.panelStudentDataRow.TabIndex = 1;
            // 
            // panelFillStudentBtns
            // 
            this.panelFillStudentBtns.Controls.Add(this.panel1);
            this.panelFillStudentBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFillStudentBtns.Location = new System.Drawing.Point(1266, 0);
            this.panelFillStudentBtns.Name = "panelFillStudentBtns";
            this.panelFillStudentBtns.Size = new System.Drawing.Size(529, 277);
            this.panelFillStudentBtns.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnStudentActivity);
            this.panel1.Controls.Add(this.btnStudentSettings);
            this.panel1.Controls.Add(this.btnStudentRecords);
            this.panel1.Location = new System.Drawing.Point(-39, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 203);
            this.panel1.TabIndex = 3;
            // 
            // btnStudentActivity
            // 
            this.btnStudentActivity.Location = new System.Drawing.Point(424, 38);
            this.btnStudentActivity.Name = "btnStudentActivity";
            this.btnStudentActivity.Size = new System.Drawing.Size(178, 127);
            this.btnStudentActivity.TabIndex = 10;
            this.btnStudentActivity.Text = "activity";
            this.btnStudentActivity.UseVisualStyleBackColor = true;
            this.btnStudentActivity.Click += new System.EventHandler(this.btnStudentActivity_Click);
            // 
            // btnStudentSettings
            // 
            this.btnStudentSettings.Location = new System.Drawing.Point(23, 38);
            this.btnStudentSettings.Name = "btnStudentSettings";
            this.btnStudentSettings.Size = new System.Drawing.Size(178, 127);
            this.btnStudentSettings.TabIndex = 8;
            this.btnStudentSettings.Text = "settings";
            this.btnStudentSettings.UseVisualStyleBackColor = true;
            this.btnStudentSettings.Click += new System.EventHandler(this.btnStudentSettings_Click);
            // 
            // btnStudentRecords
            // 
            this.btnStudentRecords.Location = new System.Drawing.Point(226, 38);
            this.btnStudentRecords.Name = "btnStudentRecords";
            this.btnStudentRecords.Size = new System.Drawing.Size(178, 127);
            this.btnStudentRecords.TabIndex = 9;
            this.btnStudentRecords.Text = "records";
            this.btnStudentRecords.UseVisualStyleBackColor = true;
            this.btnStudentRecords.Click += new System.EventHandler(this.btnStudentRecords_Click);
            // 
            // panelAdminStudentData
            // 
            this.panelAdminStudentData.Controls.Add(this.label3);
            this.panelAdminStudentData.Controls.Add(this.label2);
            this.panelAdminStudentData.Controls.Add(this.textBoxAdminStudentNumber);
            this.panelAdminStudentData.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAdminStudentData.Location = new System.Drawing.Point(629, 0);
            this.panelAdminStudentData.Name = "panelAdminStudentData";
            this.panelAdminStudentData.Size = new System.Drawing.Size(637, 277);
            this.panelAdminStudentData.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(178, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin student Data";
            // 
            // textBoxAdminStudentNumber
            // 
            this.textBoxAdminStudentNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAdminStudentNumber.Location = new System.Drawing.Point(345, 138);
            this.textBoxAdminStudentNumber.Name = "textBoxAdminStudentNumber";
            this.textBoxAdminStudentNumber.Size = new System.Drawing.Size(210, 39);
            this.textBoxAdminStudentNumber.TabIndex = 6;
            // 
            // panelStudentData
            // 
            this.panelStudentData.Controls.Add(this.labelStudentNumber);
            this.panelStudentData.Controls.Add(this.label4);
            this.panelStudentData.Controls.Add(this.label5);
            this.panelStudentData.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStudentData.Location = new System.Drawing.Point(0, 0);
            this.panelStudentData.Name = "panelStudentData";
            this.panelStudentData.Size = new System.Drawing.Size(629, 277);
            this.panelStudentData.TabIndex = 8;
            // 
            // labelStudentNumber
            // 
            this.labelStudentNumber.AutoSize = true;
            this.labelStudentNumber.Location = new System.Drawing.Point(386, 141);
            this.labelStudentNumber.Name = "labelStudentNumber";
            this.labelStudentNumber.Size = new System.Drawing.Size(124, 32);
            this.labelStudentNumber.TabIndex = 6;
            this.labelStudentNumber.Text = "undefined";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student number:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(205, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Student Data";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1795, 1185);
            this.Controls.Add(this.panelStudentDataRow);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelStudentDataRow.ResumeLayout(false);
            this.panelFillStudentBtns.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelAdminStudentData.ResumeLayout(false);
            this.panelAdminStudentData.PerformLayout();
            this.panelStudentData.ResumeLayout(false);
            this.panelStudentData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelStudentDataRow;
        private System.Windows.Forms.Panel panelStudentData;
        private System.Windows.Forms.Label labelStudentNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelAdminStudentData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdminStudentNumber;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStudentActivity;
        private System.Windows.Forms.Button btnStudentSettings;
        private System.Windows.Forms.Button btnStudentRecords;
        private System.Windows.Forms.Panel panelFillStudentBtns;
        private System.Windows.Forms.Label labelUserHeaderData;
    }
}