﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ES_aitLibary
{
    public partial class StudentRecord : Form
    {

        public static String studentNum;


        public StudentRecord()
        {
            InitializeComponent();

            labelStudentNumber.Text = studentNum;
        }

        private void labelStudentNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //for more details go to STUDENT SETTINGS return btn method
            Form mainform = Application.OpenForms["MainMenu"];
            mainform.Show();
            this.Close();
        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
