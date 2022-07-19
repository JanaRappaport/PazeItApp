using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class branchBL
    {
        private static List<supermarket> LoadSupermarket()
        {
            List<supermarket> listOfSupermarket = new List<supermarket>();
            //string constr = "metadata=res://*/Model1.csdl|res://*/Model1.ssdl|res://*/Model1.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=(LocalDB)\MSSQLLocalDB;attachdbfilename=C:\PITdataBase.mdf;integrated security=True;connect timeout=30;MultipleActiveResultSets=True;App=EntityFramework&quot;";
            //    string constr = System.Configuration.ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //    SqlCommand command = new SqlCommand("select * from questions");
            //    SqlConnection connection = new SqlConnection(constr);
            //    command.Connection = connection;

            //    try
            //    {
            //        connection.Open();
            //        using (SqlDataReader reader = command.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                Question q = new Question();
            //                q.Id = reader.GetInt32(0);
            //                q.Text = !reader.IsDBNull(1) ? reader.GetString(1) : "";
            //                listOfQuestions.Add(q);
            //            }

            //        }
            //    }
            //    catch (Exception)
            //    {

            //        MessageBox.Show("שגיאה בחיבור למסד נתונים");
            //    }
            //    finally
            //    {
            //        connection.Close();
            //    }
            return listOfSupermarket;
        }
        public static void AddBranch(string supermarketName ,string address, string branchNamr)
        {


            Branch branch = new Branch();
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.Branches.Add(branch);
                DB.SaveChanges();
            }
        }

    }
}

