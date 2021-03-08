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

namespace ES_aitLibary
{

    


    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();


            //is CHEAT admin check visible
            checkBoxIsAdminCheat.Visible = true;
            btnLoginCheat.Visible = true;

        }

        private void checkBoxIsAdminCheat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            //get data from form
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;


            //handle data 
            if (username.Length > 0 && password.Length > 0)
            {

                UserLogic ul = new UserLogic();
                User currentUser = new User();

                currentUser = ul.UserLogin(username, password);

                if(currentUser.getId() == -1)
                {
                    MessageBox.Show("there has been an error  -- userID == -1");
                }
                else
                {
                    // userLevel is an int 
                    // 1 == student
                    // >= 2 == admin

                    switch (currentUser.getUserLevel()) 
                    {
                        case 1:
                            //user level 1
                            MainMenu.isAdmin = false;
                            MainMenu.studentNumber = currentUser.getUsername();
                            break;
                        case 2:
                            // user level 2 
                            MainMenu.isAdmin = true;
                            moveToMainMenuWithClose();
                            break;

                        default:
                            MessageBox.Show("User level is outside of case 1 or 2");
                            break;
                    }

                    
                }

            }
            else
            {
                MessageBox.Show("Please fill in both username and password");
            }
            



        }


        private void moveToMainMenuWithClose()
        {
            //move to next screen
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();
        }






        private void btnLoginCheat_Click(object sender, EventArgs e)
        {

            bool adminCheat = checkBoxIsAdminCheat.Checked;

            // check admin cheat chkbox
            if (adminCheat)
            {
                //run as if admin user
                MainMenu.isAdmin = true;

            }
            else
            {
                //run as if student 
                MainMenu.isAdmin = false;

            }


            //move to next screen
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();



        }
    }
}
