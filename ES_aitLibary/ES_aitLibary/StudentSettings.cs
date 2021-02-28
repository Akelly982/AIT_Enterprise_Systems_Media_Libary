using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ES_aitLibary
{
    public partial class StudentSettings : Form
    {

        public static String studentNum;
        public static bool isAdmin;

        public StudentSettings()
        {
            InitializeComponent();

            labelStudentNumber.Text = studentNum;


            // hide admin panel if accessed by student
            if (!isAdmin)
            {
                panelAdminStudentSettings.Visible = false;
            }


        }

        private void labelStudentNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            //NOTES 
            //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.application.openforms?view=net-5.0
            //The OpenForms property represents a read-only collection of forms owned by the application. 
            //This collection can be searched by index position or by the Name of the Form.

            //address Form class as a whole not you instance of it
            //from discussion with student OpenForms[string] refers to form window text

            Form mainform = Application.OpenForms["MainMenu"];
            mainform.Show();
            this.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAdminResetPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
