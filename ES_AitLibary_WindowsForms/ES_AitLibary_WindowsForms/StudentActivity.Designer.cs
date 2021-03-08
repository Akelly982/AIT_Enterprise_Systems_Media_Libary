
namespace ES_AitLibary_WindowsForms
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
            this.panelNav = new System.Windows.Forms.Panel();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelStudentUsername = new System.Windows.Forms.Label();
            this.PanelBase = new System.Windows.Forms.Panel();
            this.PanelFees = new System.Windows.Forms.Panel();
            this.BtnPayFees = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PanelReservations = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelReservedMedia = new System.Windows.Forms.Button();
            this.PanelActiveBookings = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnReturnMedia = new System.Windows.Forms.Button();
            this.panelNav.SuspendLayout();
            this.PanelBase.SuspendLayout();
            this.PanelFees.SuspendLayout();
            this.PanelReservations.SuspendLayout();
            this.PanelActiveBookings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.Controls.Add(this.LabelStudentUsername);
            this.panelNav.Controls.Add(this.label1);
            this.panelNav.Controls.Add(this.BtnBack);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(1974, 164);
            this.panelNav.TabIndex = 1;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(837, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Student Activity";
            // 
            // LabelStudentUsername
            // 
            this.LabelStudentUsername.AutoSize = true;
            this.LabelStudentUsername.Location = new System.Drawing.Point(907, 110);
            this.LabelStudentUsername.Name = "LabelStudentUsername";
            this.LabelStudentUsername.Size = new System.Drawing.Size(107, 25);
            this.LabelStudentUsername.TabIndex = 4;
            this.LabelStudentUsername.Text = "undefined";
            // 
            // PanelBase
            // 
            this.PanelBase.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PanelBase.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PanelBase.Controls.Add(this.PanelActiveBookings);
            this.PanelBase.Controls.Add(this.PanelReservations);
            this.PanelBase.Controls.Add(this.PanelFees);
            this.PanelBase.Location = new System.Drawing.Point(625, 273);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(722, 844);
            this.PanelBase.TabIndex = 2;
            // 
            // PanelFees
            // 
            this.PanelFees.Controls.Add(this.listBox1);
            this.PanelFees.Controls.Add(this.label2);
            this.PanelFees.Controls.Add(this.BtnPayFees);
            this.PanelFees.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFees.Location = new System.Drawing.Point(0, 0);
            this.PanelFees.Name = "PanelFees";
            this.PanelFees.Size = new System.Drawing.Size(722, 272);
            this.PanelFees.TabIndex = 0;
            // 
            // BtnPayFees
            // 
            this.BtnPayFees.Location = new System.Drawing.Point(535, 88);
            this.BtnPayFees.Name = "BtnPayFees";
            this.BtnPayFees.Size = new System.Drawing.Size(153, 131);
            this.BtnPayFees.TabIndex = 0;
            this.BtnPayFees.Text = "Pay";
            this.BtnPayFees.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fees";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "$7 - late - myMediaTitle",
            "$20 - lost - myMediaTitle2"});
            this.listBox1.Location = new System.Drawing.Point(49, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(453, 154);
            this.listBox1.TabIndex = 2;
            // 
            // PanelReservations
            // 
            this.PanelReservations.Controls.Add(this.listBox2);
            this.PanelReservations.Controls.Add(this.label3);
            this.PanelReservations.Controls.Add(this.BtnCancelReservedMedia);
            this.PanelReservations.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelReservations.Location = new System.Drawing.Point(0, 272);
            this.PanelReservations.Name = "PanelReservations";
            this.PanelReservations.Size = new System.Drawing.Size(722, 272);
            this.PanelReservations.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Items.AddRange(new object[] {
            "8/02/2019 - MyGreatSoftware",
            "9/02/2019 - MyGreatSoftware4"});
            this.listBox2.Location = new System.Drawing.Point(49, 74);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(453, 154);
            this.listBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reservations";
            // 
            // BtnCancelReservedMedia
            // 
            this.BtnCancelReservedMedia.Location = new System.Drawing.Point(535, 88);
            this.BtnCancelReservedMedia.Name = "BtnCancelReservedMedia";
            this.BtnCancelReservedMedia.Size = new System.Drawing.Size(153, 131);
            this.BtnCancelReservedMedia.TabIndex = 0;
            this.BtnCancelReservedMedia.Text = "Cancel";
            this.BtnCancelReservedMedia.UseVisualStyleBackColor = true;
            // 
            // PanelActiveBookings
            // 
            this.PanelActiveBookings.Controls.Add(this.listBox3);
            this.PanelActiveBookings.Controls.Add(this.label4);
            this.PanelActiveBookings.Controls.Add(this.BtnReturnMedia);
            this.PanelActiveBookings.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelActiveBookings.Location = new System.Drawing.Point(0, 544);
            this.PanelActiveBookings.Name = "PanelActiveBookings";
            this.PanelActiveBookings.Size = new System.Drawing.Size(722, 272);
            this.PanelActiveBookings.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 25;
            this.listBox3.Items.AddRange(new object[] {
            "return by: 15/2/2022 - myMediaTitle"});
            this.listBox3.Location = new System.Drawing.Point(49, 74);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(453, 154);
            this.listBox3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Active Bookings";
            // 
            // BtnReturnMedia
            // 
            this.BtnReturnMedia.Location = new System.Drawing.Point(535, 88);
            this.BtnReturnMedia.Name = "BtnReturnMedia";
            this.BtnReturnMedia.Size = new System.Drawing.Size(153, 131);
            this.BtnReturnMedia.TabIndex = 0;
            this.BtnReturnMedia.Text = "Return";
            this.BtnReturnMedia.UseVisualStyleBackColor = true;
            // 
            // StudentActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1974, 1229);
            this.Controls.Add(this.PanelBase);
            this.Controls.Add(this.panelNav);
            this.Name = "StudentActivity";
            this.Text = "StudentActivity";
            this.panelNav.ResumeLayout(false);
            this.panelNav.PerformLayout();
            this.PanelBase.ResumeLayout(false);
            this.PanelFees.ResumeLayout(false);
            this.PanelFees.PerformLayout();
            this.PanelReservations.ResumeLayout(false);
            this.PanelReservations.PerformLayout();
            this.PanelActiveBookings.ResumeLayout(false);
            this.PanelActiveBookings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelStudentUsername;
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.Panel PanelActiveBookings;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnReturnMedia;
        private System.Windows.Forms.Panel PanelReservations;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelReservedMedia;
        private System.Windows.Forms.Panel PanelFees;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPayFees;
    }
}