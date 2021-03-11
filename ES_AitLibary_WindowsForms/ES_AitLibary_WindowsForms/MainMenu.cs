using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace ES_AitLibary_WindowsForms
{
    public partial class MainMenu : Form
    {


        public static bool isAdmin;
        public static string username;
        public MediaLogic mediaLogic;

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



            //init media libary to show all media
            mediaLogic = new MediaLogic();


            //show all media
            // set data source for data grid view
            // In this case a List<media>
            DataGridViewMediaLibary.DataSource = mediaLogic.getAllMedia();

 




        }


        private void BtnMediaLibarySearch_Click(object sender, EventArgs e)
        {

            //which radio btn are we seraching by
            // should return string 
            // title / year / genre / none
            string activeRadio = getActiveRadioBtn();

            //get text box data 
            //ensure not empty

            String userSearch = TextBoxMediaLibarySearchField.Text;
            if(userSearch.Length <= 0)
            {
                MessageBox.Show("Please input your seach by text / num in the text box.");
            }
            else
            {
                switch (activeRadio)
                {
                    case "none":
                        MessageBox.Show("Please select an active Category Radio Button");
                        break;

                    case "title":
                        DataGridViewMediaLibary.DataSource = mediaLogic.getMediaByTitle(userSearch);
                        break;

                    case "year":
                        int year = 0;
                        bool result = int.TryParse(userSearch, out year);
                        if (result)
                        {
                            DataGridViewMediaLibary.DataSource = mediaLogic.getMediaByYear(year);
                        }
                        else
                        {
                            MessageBox.Show("Could not convert your year to a number try again.");
                        }
                        break;

                    case "genre":
                         DataGridViewMediaLibary.DataSource = mediaLogic.getMediaByGenre(userSearch);
                        break;

                    default:
                        MessageBox.Show("Somthing went wrong try again -- Switch Default");
                        break;
                }
            }

            

        }


        private void BtnResetMediaLibary_Click(object sender, EventArgs e)
        {
            DataGridViewMediaLibary.DataSource = mediaLogic.getAllMedia();
        }



        private void BtnStudentSettings_Click(object sender, EventArgs e)
        {
            //index 0 == true / false 
            //index 1 == studentNum
            String[] result = getStudentUsername();

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
            String[] result = getStudentUsername();

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
            String[] result = getStudentUsername();

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


        private String[] getStudentUsername()
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
                    MessageBox.Show("please insert student username");
                    result = "false";
                }
                else
                {
                    studentNum = TextBoxAdminStudentNumber.Text;
                }

                //TODO ensure student Username enter by admin is an actural studentUsername 
                //......
                //........

            }
            else
            {
                //get from student data label
                studentNum = LabelStudentUsername.Text;
            }



            String[] tempArray = { result, studentNum };


            return tempArray;

        }


        private string getActiveRadioBtn()
        {
            string activeRadio = "none";

            // go through buttons and find one that is checked (should only be ONE)
            if (RadioBtnTitle.Checked)
            {
                activeRadio = "title";
            }
            else if(RadioBtnYear.Checked)
            {
                activeRadio = "year";
            }
            else if (RadioBtnGenre.Checked)
            {
                activeRadio = "genre";
            }
            

            return activeRadio;
        }

        
    }
}
