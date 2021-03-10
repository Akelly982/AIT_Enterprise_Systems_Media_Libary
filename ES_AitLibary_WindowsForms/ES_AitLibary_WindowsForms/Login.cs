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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            BtnCheatLoggin.Visible = true;
            ChkBoxIsAdminCheat.Visible = true;

        }

        private void BtnCheatLoggin_Click(object sender, EventArgs e)
        {
            bool adminCheat = ChkBoxIsAdminCheat.Checked;

            // check admin cheat chkbox
            if (adminCheat)
            {
                //run as if admin user
                MainMenu.isAdmin = true;
                MainMenu.username = "Admin Jimmy";
                
            }
            else
            {
                //run as if student 
                MainMenu.isAdmin = false;
                MainMenu.username = "Jimmy";
                
                

            }

            //System.Threading.Thread.Sleep(3000);
            //MoveToMainMenuWithClose();
            moveToMainMenuWithHide();

        }



        private void BtnLoggin_Click(object sender, EventArgs e)
        {
            //get data 
            string username = TextBoxUsername.Text;
            string password = TextBoxPassword.Text;

            //check if text is empty
            if (username.Length > 0 || password.Length > 0)
            {
                //send to business
                UserLogic ul = new UserLogic();
                User user = ul.UserLogin(username, password);

                //check for errors
                if (user.getId() == -1)
                {
                    MessageBox.Show("get user error UID == -1 ");
                }
                else
                {

                    moveToMainMenuWithData(user.getUserLevel(),user.getUsername());

                }
            }


            

        }



        private void BtnForgotPassword_Click(object sender, EventArgs e)
        {

        }



        private void BtnSignUp_Click(object sender, EventArgs e)
        {

        }


        //my functions---------------------------------------------------

        public void moveToMainMenuWithData(int isAdminInt, string username)
        {
            bool isAdmin = false;

            // 1 == student
            // 2 == admin

            if(isAdminInt != 1)
            {
                isAdmin = true;
            }
            

            MainMenu.isAdmin = isAdmin;
            MainMenu.username = username;
            moveToMainMenuWithHide();
        }


        public void moveToMainMenuWithClose()
        {
            //move to next screen
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();
        }

        public void moveToMainMenuWithHide()
        {
            //move to next screen
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();
        }





        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
