using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class User
    {
        private int id;
        private String username;
        private int userLevel;
        private String email;
        private String password;

        public User()
        {

        }

        public User(int userId, string username, int userLevel, string email)
        {
            this.id = userId;
            this.username = username;
            this.userLevel = userLevel;
            this.email = email;
            this.password = null;
        }



        public void setData(int userId, string username, int userLevel, string email)
        {
            this.id = userId;
            this.username = username;
            this.userLevel = userLevel;
            this.email = email;
        }


        //dose not get the password from the user table left out 
        public static User Parse(UserDS.TabUserRow userRow)
        {
            if (userRow == null)
            {
                return null;
            }
            else
            {
                //use the constructor
                User user = new User(userRow.UID, userRow.UserName, userRow.UserLevel, userRow.UserEmail);
                return user;
            }
            
        }


        public static User ParseWithPassword(UserDS.TabUserRow userRow)
        {
            if (userRow == null)
            {
                return null;
            }
            else
            {
                //use the constructor
                User user = new User(userRow.UID, userRow.UserName, userRow.UserLevel, userRow.UserEmail);
                user.setPassword(userRow.Password);
                return user;
            }

        }




        //getters
        public int getId()
        {
            return id;
        }

        public int getUserLevel()
        {
            return userLevel;
        }

        public String getEmail()
        {
            return email;
        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }




        //setters
        public void setId(int id)
        {
            this.id = id;
        }

        public void setUserLevel(int userLevel)
        {
            this.userLevel = userLevel;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }

        public void setUsername( String username)
        {
            this.username = username;
        }

        public void setPassword(String password)
        {
            this.password = password;
        }



    }
}
