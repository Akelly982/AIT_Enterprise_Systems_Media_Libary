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
    public partial class EditMediaLibary : Form
    {

        private MediaLogic mediaLogic;

        public EditMediaLibary()
        {
            InitializeComponent();

            mediaLogic = new MediaLogic();

            //connect all dataGrids and show
            getAndShowDataGridViews();

        }

        private void getAndShowDataGridViews()
        {

            //fast
            DataGridViewMedia.DataSource = mediaLogic.getAllMedia();
            DataGridViewDirector.DataSource = mediaLogic.getAllDirectorTable();
            DataGridViewLanguage.DataSource = mediaLogic.getAllLanguageTable();
            DataGridViewGenre.DataSource = mediaLogic.getAllGenreTable();

        }









        private void BtnMediaSubmit_Click(object sender, EventArgs e)
        {

            int radioBtnSelection = getActiveRadioButtonMedia();

            switch (radioBtnSelection)
            {
                case 1:   //add
                    addMedia();
                    break;
                case 2:  // update
                    updateMedia();
                    break;
                case 3:  // delete
                    deleteMedia();
                    break;
                default:
                    MessageBox.Show("I dont know which radio button you have selected for media Submit? ");
                    return;
            }

        }

        private void addMedia()
        {
            //get data 
            string title = TextBoxTitle.Text;
            string budget = TextBoxBudget.Text;
            string publishYear = TextBoxPublishYear.Text;
            string director = TextBoxDirector.Text;
            string language = TextBoxLanguage.Text;
            string genre = TextBoxGenre.Text;
            
        }
        private void updateMedia()
        {

        }

        private void deleteMedia()
        {
            
        }

        
        


        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form mainform = Application.OpenForms["MainMenu"];
            mainform.Show();
            this.Close();
        }




        private int getActiveRadioButtonMedia()
        {

            int activeRadio = -1;
            if (RadioBtnNewMediaItem.Checked)
            {
                activeRadio = 1;
            }else if (RadioBtnUpdateMedia.Checked)
            {
                activeRadio = 2;
            }
            else if (RadioBtnDeleteMedia.Checked)
            {
                activeRadio = 3;
            }

            return activeRadio;

        }




        //accidently clicked labels -------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LabelUsername_Click(object sender, EventArgs e)
        {

        }

        private void LabelUserId_Click(object sender, EventArgs e)
        {

        }


        private void EditMediaLibary_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
