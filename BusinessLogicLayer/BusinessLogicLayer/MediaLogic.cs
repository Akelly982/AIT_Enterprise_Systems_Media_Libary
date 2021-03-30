using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class MediaLogic
    {


        private MediaDAO mediaDAO;


        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
        }



        public List<Media> getAllMedia()
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getAllMediaView();

            //parse data from datatable rows to list elements
            myList = parseMediaDataTolistAll(myData);

            return myList;

        }

        public List<Media> getMediaByTitle(String title)
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByTitle(title);

            //parse data from datatable rows to list elements
            myList = parseMediaDataTolistAll(myData);

            return myList;

        }

        public List<Media> getMediaByYear(int year)
        {
            
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByYear(year);

            //parse data from datatable rows to list elements
            myList = parseMediaDataTolistAll(myData);


            return myList;

        }


        public List<Media> getMediaByGenre(String genreName)
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByGenreName(genreName);

            //parse data from datatable rows to list elements
            myList = parseMediaDataTolistAll(myData);

            return myList;

        }






        //Director tabel
        public List<IdAndValue> getAllDirectorTable()
        {
            List<IdAndValue> myList = new List<IdAndValue>();

            MediaDS.TabDirectorDataTable myData = mediaDAO.getAllDirectors();

            //parse data from datatable rows to list elements
            myList = parseDirectorDataTolist(myData);

            return myList;
        }

        public int getDirectorIdByName(string directorName)
        {
            //get data from DAO
            MediaDS.TabDirectorDataTable myData = mediaDAO.getDirectorByName(directorName);

            int recievedId = -1;

            foreach (MediaDS.TabDirectorRow row in myData.Rows) //should only result to one row
            {

                if (row != null)
                {
                    recievedId = row.DID;
                }

            }

            return recievedId; //if is -1 their is an error
        }

        public bool insertNewDirector(string directorName)
        {
            bool checker = mediaDAO.insertNewDirector(directorName);
            return checker;
        }

        public bool deleteDirectorbyId(int id)
        {
            bool checker = mediaDAO.deleteDirectorById(id);
            return checker;
        }

        



        //Genre tabel
        public List<IdAndValue> getAllGenreTable()
        {
            List<IdAndValue> myList = new List<IdAndValue>();

            MediaDS.TabGenreDataTable myData = mediaDAO.getAllGenre();

            //parse data from datatable rows to list elements
            myList = parseGenreDataTolist(myData);

            return myList;
        }

        public int getGenreIdByName(string genreName)
        {
            //get data from DAO
            MediaDS.TabGenreDataTable myData = mediaDAO.getGenreByName(genreName);

            int recievedId = -1;

            foreach (MediaDS.TabGenreRow row in myData.Rows) //should only result to one row
            {

                if (row != null)
                {
                    recievedId = row.GID;
                }

            }

            return recievedId; //if is -1 their is an error
        }

        public bool insertNewGenre(string genreName)
        {
            bool checker = mediaDAO.insertNewGenre(genreName);
            return checker;
        }

        public bool deleteGenrebyId(int id)
        {
            bool checker = mediaDAO.deleteGenreById(id);
            return checker;
        }



        //Language tabel
        public List<IdAndValue> getAllLanguageTable()
        {
            List<IdAndValue> myList = new List<IdAndValue>();

            MediaDS.TabLanguageDataTable myData = mediaDAO.getAllLanguages();

            //parse data from datatable rows to list elements
            myList = parseLanguageDataTolist(myData);

            return myList;
        }


        public int getLanguageIdByName(string languageName)
        {
            //get data from DAO
            MediaDS.TabLanguageDataTable myData = mediaDAO.getLanguageByName(languageName);

            int recievedId = -1;

            foreach (MediaDS.TabLanguageRow row in myData.Rows) //should only result to one row
            {

                if (row != null)
                {
                    recievedId = row.LID;
                }

            }

            return recievedId; //if is -1 their is an error
        }


        public bool insertNewLanguage(string languageName)
        {
            bool checker = mediaDAO.insertNewLanguage(languageName);
            return checker;
        }

        public bool deleteLanguagebyId(int id)
        {
            bool checker = mediaDAO.deleteLanguageById(id);
            return checker;
        }










        //functions ---------

        public List<Media> parseMediaDataTolistAll(MediaDS.ViewMediaDataTable myDataTable)
        {
            List<Media> mediaList = new List<Media>();

            foreach (MediaDS.ViewMediaRow row in myDataTable.Rows)
            //foreach (UserDS.TabUserRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    Media mItem = new Media(row.MediaID, row.Title, row.GenreName, row.DirectorName, row.LanguageName, row.PublishYear, row.Budget, row.Genre, row.Director, row.Language);
                    //Media mItemNoFk = new Media(row.MediaID, row.Title, row.GenreName, row.DirectorName, row.LanguageName, row.PublishYear);
                    mediaList.Add(mItem);
                }

            }

            return mediaList;

        }



        //Parse genre director and language tables usign IdAndValueClass
        //tableDirector
        public List<IdAndValue> parseDirectorDataTolist(MediaDS.TabDirectorDataTable myDataTable)
        {
            List<IdAndValue> idVal = new List<IdAndValue>();

            foreach (MediaDS.TabDirectorRow row in myDataTable.Rows)
            //foreach (UserDS.TabUserRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    IdAndValue item = new IdAndValue(row.DID, row.DirectorName);
                    idVal.Add(item);
                }

            }
            return idVal;
        }


        //tableGenre
        public List<IdAndValue> parseGenreDataTolist(MediaDS.TabGenreDataTable myDataTable)
        {
            List<IdAndValue> idVal = new List<IdAndValue>();

            foreach (MediaDS.TabGenreRow row in myDataTable.Rows)
            //foreach (UserDS.TabUserRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    IdAndValue item = new IdAndValue(row.GID, row.GenreName);
                    idVal.Add(item);
                }

            }
            return idVal;
        }

        //tableLanguage
        public List<IdAndValue> parseLanguageDataTolist(MediaDS.TabLanguageDataTable myDataTable)
        {
            List<IdAndValue> idVal = new List<IdAndValue>();

            foreach (MediaDS.TabLanguageRow row in myDataTable.Rows)
            //foreach (UserDS.TabUserRow row in myDataTable.Rows)
            {

                if (row == null)
                {
                    return null;
                }
                else
                {
                    IdAndValue item = new IdAndValue(row.LID, row.LanguageName);
                    idVal.Add(item);
                }

            }
            return idVal;
        }




    }
}
