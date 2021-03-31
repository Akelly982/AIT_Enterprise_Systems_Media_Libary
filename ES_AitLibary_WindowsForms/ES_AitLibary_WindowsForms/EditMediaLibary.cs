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
        
        // on dataGridView Row click set row active
        private DataGridViewRow activeMediaRow = null;
        private DataGridViewRow activeDirectorRow = null;
        private DataGridViewRow activeLanguageRow = null;
        private DataGridViewRow activeGenreRow = null;


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

            //check data 

            //add new media to table
            
        }
        private void updateMedia()
        {

            //get selection 
            // cell[0] is the id index
            string idAsStr = activeMediaRow.Cells[0].Value.ToString();
            bool result = int.TryParse(idAsStr, out int id);  //try parse idAsStr to int id

            //check if getting row selection id was succesfull
            if (!result)
            {
                MessageBox.Show("Media: error converting id string to id int");
                return; //should end method here 
            }
            

            //get data 
            string title = TextBoxTitle.Text;
            string budget = TextBoxBudget.Text;
            string publishYear = TextBoxPublishYear.Text;
            string director = TextBoxDirector.Text;
            string language = TextBoxLanguage.Text;
            string genre = TextBoxGenre.Text;

            //check data 
            // if anything is left empty inform user (basics)
            if(title.Length <= 0 || budget.Length <= 0 || publishYear.Length <= 0 || 
                director.Length <= 0 || language.Length <= 0 || genre.Length <= 0)
            {
                MessageBox.Show("please fill in all fields");
                return;
            }



            //update selected media



        }

        private void deleteMedia()
        {
            //get selection
            // cell[0] is the id index
            string idAsStr = activeMediaRow.Cells[0].Value.ToString();
            bool result = int.TryParse(idAsStr, out int id);  //try parse idAsStr to int id

            //delete selection
            if (result) 
            {
                mediaLogic.deleteMediabyId(id);
            }
            else
            {
                MessageBox.Show("Media: error converting id string to id int");
            }
            
            
        }

        
        


        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form mainform = Application.OpenForms["MainMenu"];
            mainform.Show();
            this.Close();
        }





        // data grid working with
        private void DataGridViewMedia_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // cells / columns by index
                // 0 == ID
                // 1 == title
                // 2 == genre name
                // 3 == directorName
                // 4 == language name
                // 5 == publish year
                // 6 == budget
                // 7 == genre id
                // 8 == director ID
                // 9 == language ID


                //get row by its self
                DataGridViewRow row = DataGridViewMedia.Rows[e.RowIndex];
                
                //set row data by cell id to text boxes next to dataGridViewMedia
                TextBoxTitle.Text = row.Cells[1].Value.ToString();
                TextBoxGenre.Text = row.Cells[2].Value.ToString();
                TextBoxDirector.Text = row.Cells[3].Value.ToString();
                TextBoxLanguage.Text = row.Cells[4].Value.ToString();
                TextBoxPublishYear.Text = row.Cells[5].Value.ToString();
                TextBoxBudget.Text = row.Cells[6].Value.ToString();


                //set mediaRow as active 
                activeMediaRow = row;

            }

        }



        // delete btn press for director, language and genre
        private void BtnDeleteDirector_Click(object sender, EventArgs e)
        {
            //get selection
            // cell[0] is the id index
            string idAsStr = activeDirectorRow.Cells[0].Value.ToString();
            bool result = int.TryParse(idAsStr, out int id);  //try parse idAsStr to int id

            //delete selection
            if (result)
            {
                mediaLogic.deleteDirectorbyId(id);
            }
            else
            {
                MessageBox.Show("Director: error converting id string to id int");
            }
        }

        private void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            //get selection
            // cell[0] is the id index
            string idAsStr = activeGenreRow.Cells[0].Value.ToString();
            bool result = int.TryParse(idAsStr, out int id);  //try parse idAsStr to int id

            //delete selection
            if (result)
            {
                mediaLogic.deleteGenrebyId(id);
            }
            else
            {
                MessageBox.Show("genre: error converting id string to id int");
            }
        }

        private void BtnDeleteLanguage_Click(object sender, EventArgs e)
        {
            //get selection
            // cell[0] is the id index
            string idAsStr = activeLanguageRow.Cells[0].Value.ToString();
            bool result = int.TryParse(idAsStr, out int id);  //try parse idAsStr to int id

            //delete selection
            if (result)
            {
                mediaLogic.deleteLanguagebyId(id);
            }
            else
            {
                MessageBox.Show("Language: error converting id string to id int");
            }
        }





        // data grid view cell click
        private void DataGridViewDirector_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0)
            {
                // cells / columns by index
                // 0 == ID
                // 1 == Value


                //get row by its self
                DataGridViewRow row = DataGridViewDirector.Rows[e.RowIndex];

               
                //set mediaRow as active 
                activeDirectorRow = row;

            }


        }

        private void DataGridViewGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // cells / columns by index
                // 0 == ID
                // 1 == Value


                //get row by its self
                DataGridViewRow row = DataGridViewGenre.Rows[e.RowIndex];


                //set mediaRow as active 
                activeGenreRow = row;

            }
        }

        private void DataGridViewLanguage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // cells / columns by index
                // 0 == ID
                // 1 == Value


                //get row by its self
                DataGridViewRow row = DataGridViewLanguage.Rows[e.RowIndex];


                //set mediaRow as active 
                activeLanguageRow = row;

            }
        }


        // media return active radio btn function
        private int getActiveRadioButtonMedia()
        {

            int activeRadio = -1;
            if (RadioBtnNewMediaItem.Checked)
            {
                activeRadio = 1;
            }
            else if (RadioBtnUpdateMedia.Checked)
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
