
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

        public async Task<IHttpActionResult> DeleteUser(int id)
        {
            try
            {
                using (PITdataBaseEntities DB = new PITdataBaseEntities())
                {
                    int guid_id = id;
                    var deleteuser = DB.users.FirstOrDefault(e => e.Id == guid_id);
                    if (deleteuser == null)
                    {
                        return Content(HttpStatusCode.NotFound, "User Not Found");
                    }
                    else
                    {
                        var q =
                    from user in DB.users
                    join resource in DB.Resources
                    on user.Id equals resource.UserId
                    from role in user.Roles
                    from ofc in user.Offices
                    where user.Id == guid_id
                    select new
                    {
                        Users = user,
                        Resources = resource,
                        Roles = role,
                        Offices = ofc
                    };
                        foreach (var item in q)
                        {
                            deleteuser.Roles.Remove(item.Roles);
                            deleteuser.Offices.Remove(item.Offices);
                            DB.Resources.Remove(item.Resources);
                            DB.users.Remove(item.Users);
                        }
                        await DB.SaveChangesAsync();
                    }
                }
                return Ok(Helper.SuccessResponse("User Deleted"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
