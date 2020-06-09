using DAL.EF;
//using DAL.EntitiesFramwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class UserBL
    {
        public static object GetUsers()
        {
            try
            {

                using (Travel_In_GroupDBEntities1 db = new Travel_In_GroupDBEntities1())
                {
                
                    return db.Users.ToList();
                }

            }
            catch (Exception e)
            {
                throw new Exception("error");
            }
        }
    }

}
