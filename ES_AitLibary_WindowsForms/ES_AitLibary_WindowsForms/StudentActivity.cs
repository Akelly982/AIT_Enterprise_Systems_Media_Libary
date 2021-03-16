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
    public partial class StudentActivity : Form
    {

        
        public static bool isAdmin;
        public static User user;

        public StudentActivity()
        {
            InitializeComponent();

            LabelUsername.Text = user.Username;
            LabelUserId.Text = user.Id.ToString();


            // hide admin panel / content
            if (!isAdmin)
            {
                
            }



        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //for more details go to STUDENT SETTINGS return btn method
            Form mainform = Application.OpenForms["MainMenu"];
            mainform.Show();
            this.Close();
        }





    }
}
