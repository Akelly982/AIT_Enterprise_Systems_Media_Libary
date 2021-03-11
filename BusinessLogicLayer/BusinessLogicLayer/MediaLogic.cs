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
        private MediaDS.TabMediaDataTable mediaTable;
        private MediaDS.ViewMediaDataTable viewMediaTable;


        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
            mediaTable = new MediaDS.TabMediaDataTable();
            viewMediaTable = new MediaDS.ViewMediaDataTable();
        }



        public List<Media> getAllMedia()
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getAllMediaView();

            //parse data from datatable rows to list elements
            myList = parseDataTolistAll(myData);

            return myList;

        }

        public List<Media> getMediaByTitle(String title)
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByTitle(title);

            //parse data from datatable rows to list elements
            myList = parseDataTolistAll(myData);

            return myList;

        }

        public List<Media> getMediaByYear(int year)
        {
            
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByYear(year);

            //parse data from datatable rows to list elements
            myList = parseDataTolistAll(myData);


            return myList;

        }


        public List<Media> getMediaByGenre(String genreName)
        {
            List<Media> myList = new List<Media>();

            MediaDS.ViewMediaDataTable myData = mediaDAO.getMediaByGenreName(genreName);

            //parse data from datatable rows to list elements
            myList = parseDataTolistAll(myData);

            return myList;

        }











        //functions ---------

        public List<Media> parseDataTolistAll(MediaDS.ViewMediaDataTable myDataTable)
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

                    mediaList.Add(mItem);
                }

            }

            return mediaList;

        }
        





    }
}
