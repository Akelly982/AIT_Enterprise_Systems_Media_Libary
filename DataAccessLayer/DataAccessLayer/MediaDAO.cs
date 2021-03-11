﻿using DataAccessLayer.MediaDSTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MediaDAO
    {

        private MediaDS mediaDataSet;
        private TabMediaTableAdapter tabMediaAdapter;
        private ViewMediaTableAdapter viewMediaTableAdapter;


        public MediaDAO()
        {
            mediaDataSet = new MediaDS();
            tabMediaAdapter = new TabMediaTableAdapter();
            viewMediaTableAdapter = new ViewMediaTableAdapter();
        }


        public MediaDS.TabMediaDataTable getAllMediaTab()
        {
            try
            {
                tabMediaAdapter.FillAll(mediaDataSet.TabMedia);
                return mediaDataSet.TabMedia;
            }
            catch (Exception e)
            {
                throw e;
            }

        }



        // name of data table within the DS
        public MediaDS.ViewMediaDataTable getMediaByGenreId(int genreId)
        {
            try
            {
                //adapter in ds schema    //yourFill method   //the schema u are using  // variables needed if any
                viewMediaTableAdapter.FillByGenre(mediaDataSet.ViewMedia, genreId);
                //return the now filled schema / table
                return mediaDataSet.ViewMedia;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public MediaDS.ViewMediaDataTable getMediaByGenreName(string genreName)
        {
            try
            {
                viewMediaTableAdapter.FillByGenreName(mediaDataSet.ViewMedia, genreName);
                return mediaDataSet.ViewMedia;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public MediaDS.ViewMediaDataTable getMediaByYear(int year)
        {

            try
            {
                viewMediaTableAdapter.FillByPublishYear(mediaDataSet.ViewMedia, year);
                return mediaDataSet.ViewMedia;
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        public MediaDS.ViewMediaDataTable getMediaByTitle(string title)
        {
            try
            {
                viewMediaTableAdapter.FillByTitleName(mediaDataSet.ViewMedia, title);
                return mediaDataSet.ViewMedia;
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        // Note this is media View not media Table
        public MediaDS.ViewMediaDataTable getAllMediaView()
        {

            try
            {
                
                viewMediaTableAdapter.FillAll(mediaDataSet.ViewMedia);
                return mediaDataSet.ViewMedia;

            }
            catch (Exception e)
            {
                throw e;
            }

        }






    }
}