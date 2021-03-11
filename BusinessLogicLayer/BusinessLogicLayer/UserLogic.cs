using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class UserLogic
    {



        //if you are struggleing to find your class listed
        // make sure that your class is a public class

        private UserDAO userDAO;
        private UserDS.TabUserDataTable userTable;


        public UserLogic()
        {
            userDAO = new UserDAO();
            userTable = new UserDS.TabUserDataTable();
        }




        // gets singular user
        public User userLogin(string username,string password)
        {



            User user = new User();

            // get our table data from our DAO
            userTable = userDAO.GetUserByLogin(username, password);

            //go through table data row by row
            if(userTable.Count == 1) // their should only be one user 
            {
                //get data 
                foreach(UserDS.TabUserRow userRow in userTable.Rows)
                {
                    user.setData(userRow.UID, userRow.UserName, userRow.UserLevel, userRow.UserEmail);
                }
            }
            else
            {
                user.setId(-1);
            }


            //User will be either fully set or have an id of -1

            return user;

        }






        public User getUserById(int userId)
        {

            User user = new User();

            // get our table data from our DAO
            userTable = userDAO.GetUserById(userId);

            //go through table data row by row
            if (userTable.Count == 1) // their should only be one user 
            {
                //get data 
                foreach (UserDS.TabUserRow userRow in userTable.Rows)
                {
                    user.setData(userRow.UID, userRow.UserName, userRow.UserLevel, userRow.UserEmail);
                }
            }
            else
            {
                user.setId(-1);
            }


            //User will be either fully set or have an id of -1

            return user;

        }














    }
}
