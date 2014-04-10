using NHibernateLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatorGradNet.BusinessLayer
{
    public class UserManagement
    {
        private static UserManagement userManagementInstance = new UserManagement();

        public static UserManagement Instance()
        {

            return userManagementInstance;
        }

        public ProfileUser Login(String userName, String password)
        {
            NHibernateLibrary.Entities.ProfileUser profileUser = null;
            if (userName != null && password != null)
            {
                profileUser = new NHibernateLibrary.Entities.ProfileUser();
                profileUser.Username = userName;
                profileUser.Password = password;
                profileUser = DataAccessLayer.UserManagement.Instance().Login(profileUser);
            }
            //return new DataAccessLayer.UserManagement().Login(profileUser);
            return profileUser;
        }

        public bool UserExistsOrNot(String userName)
        {
            bool userExists = false;
            NHibernateLibrary.Entities.ProfileUser profileUser = null;
            if (userName != null)
            {
                profileUser = new NHibernateLibrary.Entities.ProfileUser();
                profileUser.Username = userName;
                userExists = DataAccessLayer.UserManagement.Instance().CheckIfUserExists(profileUser);
            }
            return userExists;
        }
        public bool RegisterUser(String Username, String Password, String Email)
        {
            NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            PUser.Username = Username;
            PUser.Password = Password;
            PUser.Email = Email;
            PUser.PrevEducation = "";
            PUser.PrevLocation = "";
            PUser.PrevWork = "";
            PUser.CurrentWork = "";
            //PUser.

            return DataAccessLayer.UserManagement.Instance().RegisterUser(PUser);
        }
        public bool UpdateUserProfile(int UserID, String Username, String Password, String Email, String PrevEducation, String PrevWork, String PrevLocation, String CurrentWork)
        {
            NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            //PUser. = UserID;
            PUser.Username = Username;
            PUser.Password = Password;
            PUser.Email = Email;
            PUser.PrevEducation = PrevEducation;
            PUser.PrevLocation = PrevLocation;
            PUser.PrevWork = PrevWork;
            return DataAccessLayer.UserManagement.Instance().RegisterUser(PUser);
        }
        public NHibernateLibrary.Entities.ProfileUser GetUserProfile(String Username)
        {
            NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            PUser.Username = Username;
            return DataAccessLayer.UserManagement.Instance().GetUserProfile(PUser);
        }
        public String[] GetGatorsByLocation(String Location)
        {
            //NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            //PUser.Username = Username;

            return DataAccessLayer.UserManagement.Instance().GetGators(DataAccessLayer.UserManagement.Criterion.Location, Location);
        }
        public String[] GetGatorsByPreviousEmployment(String Employment)
        {
            //NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            //PUser.Username = Username;
        
            return DataAccessLayer.UserManagement.Instance().GetGators(DataAccessLayer.UserManagement.Criterion.Work, Employment);
        }
        public String[] GetGatorsByPreviousSchool(String Education)
        {
        
            return DataAccessLayer.UserManagement.Instance().GetGators(DataAccessLayer.UserManagement.Criterion.Education, Education);
        }
    }
}
