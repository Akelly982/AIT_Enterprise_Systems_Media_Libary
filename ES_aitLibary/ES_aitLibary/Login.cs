using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_aitLibary
{

    


    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();


            //is CHEAT admin check visible
            checkBoxIsAdminCheat.Visible = true;

        }

        private void checkBoxIsAdminCheat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
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


            //get data from form
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            //handle data 
            //........
            //.......


            //move to next screen
            MainMenu m = new MainMenu();
            m.Show();
            this.Hide();





        }





    }
}
