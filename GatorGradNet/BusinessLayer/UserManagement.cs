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
        public bool UpdateUserProfile(String Username, String FirstName, String LastName, String Password, String Email, String PrevEducation, String PrevWork, String PrevLocation, String CurrentWork, float GPA, String DreamCompany,String Branch)
        {

            ProfileUser user = BusinessLayer.UserManagement.Instance().GetUserProfile(Username);
            if(!String.IsNullOrEmpty(FirstName))user.FirstName = FirstName;
            if (!String.IsNullOrEmpty(LastName)) user.LastName = LastName;
            if (!String.IsNullOrEmpty(Password)) user.Password = Password;
            if (!String.IsNullOrEmpty(Email)) user.Email = Email;
            if (!String.IsNullOrEmpty(PrevEducation)) user.PrevEducation = PrevEducation;
            if (!String.IsNullOrEmpty(PrevWork)) user.PrevWork = PrevWork;
            if (!String.IsNullOrEmpty(PrevLocation)) user.PrevLocation = PrevLocation;
            if (!String.IsNullOrEmpty(CurrentWork)) user.CurrentWork = CurrentWork;
            if (!float.IsNaN(GPA)) user.GPA = GPA;
            if (!String.IsNullOrEmpty(DreamCompany)) user.DreamCompany = DreamCompany;
            if (!String.IsNullOrEmpty(Branch)) user.Branch = Branch;
            return DataAccessLayer.UserManagement.Instance().UpdateUserProfile(user);
        }
        public NHibernateLibrary.Entities.ProfileUser GetUserProfile(String Username)
        {
            NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            PUser.Username = Username;
            return DataAccessLayer.UserManagement.Instance().GetUserProfile(PUser);
        }
        public IList<ProfileUser> GetGatorsByLocation(String Location)
        {
            //NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            //PUser.Username = Username;

            return DataAccessLayer.UserManagement.Instance().GetGators(DataAccessLayer.UserManagement.Criterion.Location, Location);
        }
        public IList<ProfileUser> GetGatorsByPreviousEmployment(String Employment)
        {
            //NHibernateLibrary.Entities.ProfileUser PUser = new NHibernateLibrary.Entities.ProfileUser();
            //PUser.Username = Username;
        
            return DataAccessLayer.UserManagement.Instance().GetGators(DataAccessLayer.UserManagement.Criterion.Work, Employment);
        }
        public IList<ProfileUser> GetGatorsByPreviousSchool(String Education)
        {
        
            return DataAccessLayer.UserManagement.Instance().GetGators(DataAccessLayer.UserManagement.Criterion.Education, Education);
        }
    }
}
