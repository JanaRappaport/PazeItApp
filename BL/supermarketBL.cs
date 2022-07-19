using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class supermarketBL
    {
        public static void AddSupermarket(supermarketDTO supermarket) 
        {
            using (PITdataBaseEntities DB = new PITdataBaseEntities())
            {
                DB.supermarkets.Add(converters.supermarketCoverters.Map(supermarket));
                DB.SaveChanges();
            }
        }

    }

}
