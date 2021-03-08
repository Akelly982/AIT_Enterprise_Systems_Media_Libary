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

        public static String studentUsername;
        public static bool isAdmin;

        public StudentSettings()
        {
            InitializeComponent();

            LabelStudentUsername.Text = studentUsername;


            // hide admin panel / content
            if (!isAdmin)
            {
                PanelAdmin.Visible = false;
            }


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
    }
}
