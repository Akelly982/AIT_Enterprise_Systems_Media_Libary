using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ES_aitLibary
{
    public partial class MainMenu : Form
    {


        public static bool isAdmin;



        public MainMenu()
        {
            InitializeComponent();

            
            //check if user is an admin
            if (isAdmin)
            {
                //hide student panels
                panelStudentData.Visible = false;  
            }
            else
            {
                //hide admin panels
                panelAdminStudentData.Visible = false;
            }

            

            
        }


        private void btnBack_Click(object sender, EventArgs e)
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




        // ------- STDUENT BASED BUTTONS -------------------------------------------

        private void btnStudentSettings_Click(object sender, EventArgs e)
        {

            //index 0 == true / false 
            //index 1 == studentNum
            String[] result = getStudentNumber();

            if (result[0].ToLower() == "true")
            {
                //set data 
                StudentSettings.studentNum = result[1];


                //move between forms
                StudentSettings ss = new StudentSettings();
                ss.Show();
                this.Hide();

            }


        }




        private void btnStudentRecords_Click(object sender, EventArgs e)
        {

            //index 0 == true / false 
            //index 1 == studentNum
            String[] result = getStudentNumber();

            if (result[0].ToLower() == "true")
            {
                //set data 
                StudentRecord.studentNum = result[1];


                //move between forms
                StudentRecord sr = new StudentRecord();
                sr.Show();
                this.Hide();

            }

        }




        private void btnStudentActivity_Click(object sender, EventArgs e)
        {

            //index 0 == true / false        
            //index 1 == studentNum
            String[] result = getStudentNumber();

            if (result[0].ToLower() == "true")
            {
                //set data 
                StudentActivity.studentNum = result[1];


                //move between forms
                StudentActivity sa = new StudentActivity();
                sa.Show();
                this.Hide();

            }

        }

        










        // -- AK FUNCTIONS ------------------------------------------

        //index 0 == true / false 
        //index 1 == studentNum
        private String[] getStudentNumber()
        {
            string result = "true";
            string studentNum = "undefined";

            //get data (studentNum / ID)
            if (isAdmin)
            {
                //get from admin student data text box 
                //ensure text box is not empty first
                if (textBoxAdminStudentNumber.Text.Length == 0)
                {
                    MessageBox.Show("please insert student number");
                     result = "false";
                }
                else
                {
                    studentNum = textBoxAdminStudentNumber.Text;
                }

                //TODO ensure studentNum is an actural student number 
                //......
                //........

            }
            else
            {
                //get from student data label
                studentNum = labelStudentNumber.Text;
            }


            //TODO ensure student number is an actural student number 
            //.....
            //.....


            String[] tempArray = { result, studentNum };


            return tempArray;

        }

        

    }
}
