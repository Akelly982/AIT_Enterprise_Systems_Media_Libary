using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_AitLibary_WindowsForms
{
    public partial class MainMenu : Form
    {


        public static bool isAdmin;
        public static string username;

        public MainMenu()
        {
            InitializeComponent();


            if (!isAdmin)
            {
                LabelStudentUsername.Text = username;
                LabelAdminUsername.Visible = false;

                PanelMediaLibaryAdminBtns.Visible = false;
                PanelStudentRowShowAdminContent.Visible = false;

            }
            else
            {
                LabelAdminUsername.Text = "Admin " + username;
                PanelStudentRowShowStudentContent.Visible = false;
            }

            


        }


        private void BtnMediaLibarySearch_Click(object sender, EventArgs e)
        {

        }



        private void BtnStudentSettings_Click(object sender, EventArgs e)
        {
            //index 0 == true / false 
            //index 1 == studentNum
            String[] result = getStudentNumber();

            if (result[0].ToLower() == "true")
            {
                //set data 
                StudentSettings.studentUsername = result[1];
                StudentSettings.isAdmin = isAdmin;


                //move between forms
                StudentSettings ss = new StudentSettings();
                ss.Show();
                this.Hide();

            }
        }



        private void BtnStudentRecords_Click(object sender, EventArgs e)
        {
            //index 0 == true / false 
            //index 1 == studentNum
            String[] result = getStudentNumber();

            if (result[0].ToLower() == "true")
            {
                //set data 
                StudentSettings.studentUsername = result[1];
                StudentSettings.isAdmin = isAdmin;


                //move between forms
                StudentRecord sr = new StudentRecord();
                sr.Show();
                this.Hide();

            }
        }



        private void BtnStudentActivity_Click(object sender, EventArgs e)
        {
            //index 0 == true / false        
            //index 1 == studentNum
            String[] result = getStudentNumber();

            if (result[0].ToLower() == "true")
            {
                //set data 
                StudentSettings.studentUsername = result[1];
                StudentSettings.isAdmin = isAdmin;


                //move between forms
                StudentActivity sa = new StudentActivity();
                sa.Show();
                this.Hide();

            }
        }



        private void BtnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            returnToLogin();
        }






        private void returnToLogin()
        {

            //create login instance
            Login loginScreen = new Login();
            //show login page
            loginScreen.Show();
            //close this page
            this.Close();

        }


        private String[] getStudentNumber()
        {
            string result = "true";
            string studentNum = "undefined";

            //get data (studentNum / ID)
            if (isAdmin)
            {
                //get from admin student data text box 
                //ensure text box is not empty first
                if (TextBoxAdminStudentNumber.Text.Length == 0)
                {
                    MessageBox.Show("please insert student number");
                    result = "false";
                }
                else
                {
                    studentNum = TextBoxAdminStudentNumber.Text;
                }

                //TODO ensure studentNum is an actural student number 
                //......
                //........

            }
            else
            {
                //get from student data label
                studentNum = LabelStudentUsername.Text;
            }


            //TODO ensure student number is an actural student number 
            //.....
            //.....


            String[] tempArray = { result, studentNum };


            return tempArray;

        }





    }
}
