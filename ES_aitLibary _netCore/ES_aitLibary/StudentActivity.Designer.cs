
namespace ES_aitLibary
{
    partial class StudentActivity
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.labelStudentNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnReturnMedia = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPayFees = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(871, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Activity";
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
            this.panel1.TabIndex = 1;
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
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(625, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 819);
            this.panel2.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnReturnMedia);
            this.panel5.Controls.Add(this.listBox2);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 512);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(754, 256);
            this.panel5.TabIndex = 2;
            // 
            // btnReturnMedia
            // 
            this.btnReturnMedia.Location = new System.Drawing.Point(588, 98);
            this.btnReturnMedia.Name = "btnReturnMedia";
            this.btnReturnMedia.Size = new System.Drawing.Size(119, 109);
            this.btnReturnMedia.TabIndex = 3;
            this.btnReturnMedia.Text = "Return";
            this.btnReturnMedia.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 32;
            this.listBox2.Items.AddRange(new object[] {
            "return by: 15/2/2022 - myMediaTitle"});
            this.listBox2.Location = new System.Drawing.Point(85, 108);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(447, 100);
            this.listBox2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Active bookings";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelReservation);
            this.panel4.Controls.Add(this.listBox1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 256);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(754, 256);
            this.panel4.TabIndex = 1;
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Location = new System.Drawing.Point(588, 83);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(119, 109);
            this.btnCancelReservation.TabIndex = 4;
            this.btnCancelReservation.Text = "Cancel";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 32;
            this.listBox1.Items.AddRange(new object[] {
            "8/02/2019 - MyGreatSoftware",
            "9/02/2019 - MyGreatSoftware4"});
            this.listBox1.Location = new System.Drawing.Point(85, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(447, 100);
            this.listBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Reservations";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnPayFees);
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(754, 256);
            this.panel3.TabIndex = 0;
            // 
            // btnPayFees
            // 
            this.btnPayFees.Location = new System.Drawing.Point(588, 89);
            this.btnPayFees.Name = "btnPayFees";
            this.btnPayFees.Size = new System.Drawing.Size(119, 109);
            this.btnPayFees.TabIndex = 4;
            this.btnPayFees.Text = "Pay";
            this.btnPayFees.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 32;
            this.listBox3.Items.AddRange(new object[] {
            "$7 - late - myMediaTitle",
            "$20 - lost - myMediaTitle2"});
            this.listBox3.Location = new System.Drawing.Point(85, 98);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(447, 100);
            this.listBox3.TabIndex = 3;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fees";
            // 
            // StudentActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1974, 1229);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StudentActivity";
            this.Text = "StudentActivity";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label labelStudentNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturnMedia;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnPayFees;
    }
}