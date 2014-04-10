using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatorGradNet.BusinessLayer
{
    public class UserFunctions
    {
        public bool LoginCheck(String Username, String Password)
        {
            NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            PUser.Username = Username;
            PUser.Password = Password;
            DataAccessLayer.UserFunctions UFunc = new DataAccessLayer.UserFunctions();
            return UFunc.LoginCheck(PUser);
        }
        public bool UserExistsOrNot(String Username)
        {
            NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            PUser.Username = Username;
            DataAccessLayer.UserFunctions UFunc = new DataAccessLayer.UserFunctions();
            return UFunc.UserExistsOrNot(PUser);
        }
        public bool RegisterUser(String Username, String Password)
        {
            NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            PUser.Username = Username;
            PUser.Password = Password;
            DataAccessLayer.UserFunctions UFunc = new DataAccessLayer.UserFunctions();
            return UFunc.RegisterUser(PUser);
        }
    }
}
