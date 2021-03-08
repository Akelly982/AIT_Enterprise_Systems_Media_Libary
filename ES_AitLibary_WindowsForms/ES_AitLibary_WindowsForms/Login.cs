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
                //move to next screen
                MainMenu m = new MainMenu();
                m.Show();
                this.Hide();

                //Login login = this;
                //login.Hide();
            }
            else
            {
                //run as if student 
                MainMenu.isAdmin = false;
                MainMenu.username = "Jimmy";
                //move to next screen
                MainMenu m = new MainMenu();
                m.Show();
                this.Close();

            }


            //MoveToMainMenuWithClose();


        }



        private void BtnLoggin_Click(object sender, EventArgs e)
        {

        }



        private void BtnForgotPassword_Click(object sender, EventArgs e)
        {

        }



        private void BtnSignUp_Click(object sender, EventArgs e)
        {

        }



        

        public void MoveToMainMenuWithClose()
        {
            //move to next screen
            MainMenu m = new MainMenu();
            m.Show();
            this.Close();
        }





        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
