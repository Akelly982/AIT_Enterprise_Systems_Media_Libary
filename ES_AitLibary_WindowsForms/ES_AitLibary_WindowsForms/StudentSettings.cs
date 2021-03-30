using BusinessLogicLayer;
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
    public partial class StudentSettings : Form
    {

        public static bool isAdmin;
        public static User user;

        private UserLogic userLogic;

        public StudentSettings()
        {
            InitializeComponent();

            LabelUsername.Text = user.Username;
            LabelUserId.Text = user.Id.ToString();

            // hide admin panel / content
            if (!isAdmin)
            {
                PanelAdmin.Visible = false;
            }

            userLogic = new UserLogic();

        }

        private void BtnBack_Click(object sender, EventArgs e)
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




        private void BtnAdminResetPassword_Click(object sender, EventArgs e)
        {
            string newPass = TextBoxAdminPasswordReset.Text;
            
            //check if empty
            if (newPass.Length <= 0)
            {
                MessageBox.Show("please fill in the admin new password textbox ");
                return;
            }

            bool result = userLogic.updateUserPassword(user.Id, newPass);

            if (result)
            {
                MessageBox.Show("Password updated to: " + newPass);
            }
            else
            {
                MessageBox.Show("db returned false their was an error.");
            }

        }

        private void BtnAdminDelete_Click(object sender, EventArgs e)
        {
            if (!ChkBoxDelete.Checked)
            {
                MessageBox.Show("please check the delete user check box.");
            }
            else
            {
                bool result = userLogic.deleteUser(user.Id);

                if (result)
                {
                    MessageBox.Show("user deleted successfully");

                    //return to main menu
                    Form mainform = Application.OpenForms["MainMenu"];
                    mainform.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("db returned false their was an error.");
                }
            }
        }
    }
}
