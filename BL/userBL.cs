
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
   public class userBL
    {
        public static void AddUser(userDTO user)
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.users.Add(converters.userConverter.Map(user));
                DB.SaveChanges();
            }
        }

        public static List<DAL.user> GetAllUsers()
        {
            List<DAL.user> listOfUsers = new List<DAL.user>();
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {

            }
        }
    }
}
