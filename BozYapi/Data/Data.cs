using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BozYapi.Models;
namespace BozYapi.Data
{
    public class Data
    {
        public static tbl_Contact get_Contact (int id)
        {
            using (BozYapiDBEntities db= new BozYapiDBEntities())
            {
                return db.tbl_Contact.Where(a => a.Contact_ID == id).SingleOrDefault();
            }
        }


        public static tbl_Services get_Services(int id)
        {
            using (BozYapiDBEntities db = new BozYapiDBEntities())
            {
                return db.tbl_Services.Where(s => s.Service_ID == id).SingleOrDefault();
            }
        }

        public static tbl_Aboutus get_Aboutus(int id)
        {
            using (BozYapiDBEntities db = new BozYapiDBEntities())
            {
                return db.tbl_Aboutus.Where(s => s.Aboutus_ID == id).SingleOrDefault();
            }
        }

        public static List<tbl_Images> get_Images()
        {
            using (BozYapiDBEntities db = new BozYapiDBEntities())
            {
                return db.tbl_Images.ToList();
            }
        }

    }
}