using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.ReservedDSTableAdapters;

namespace DataAccessLayer
{
    class ReservedDAO
    {



        private ReservedDS reservedDataSet;
        private TabReservedTableAdapter tabReservedTableAdapter;



        public ReservedDAO()
        {
            reservedDataSet = new ReservedDS();
            tabReservedTableAdapter = new TabReservedTableAdapter();
        }



        public ReservedDS.TabReservedDataTable getAllReservedTab()
        {
            try
            {
                tabReservedTableAdapter.FillAll(reservedDataSet.TabReserved);
                return reservedDataSet.TabReserved;
            }
            catch (Exception e)
            {
                throw e;
            }

        }




    }
}
