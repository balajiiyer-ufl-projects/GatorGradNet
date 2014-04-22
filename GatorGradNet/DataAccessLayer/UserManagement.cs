using Common;
using NHibernateLibrary.Entities;
using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Transaction;
using System.Threading.Tasks;
using NHibernate;

namespace GatorGradNet.DataAccessLayer
{
    public class UserManagement : BaseDataAccess<ProfileUser, Int64>
    {
        public  enum Criterion { Location, Education, Work };

        private static UserManagement userManagementInstance = new UserManagement();

        UserManagement () { }

        public static UserManagement Instance(){

            return userManagementInstance;
        }

        #region Login
        public ProfileUser Login(NHibernateLibrary.Entities.ProfileUser profileUser)
        {
            IList<NHibernateLibrary.Entities.ProfileUser> userList=null;
            var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.Username == profileUser.Username && user.Password==profileUser.Password);

            if (query != null && query.RowCount() > 0)
            {
                userList = query.List<NHibernateLibrary.Entities.ProfileUser>();
                return Common.Utils<ProfileUser>.TrimStringProperties(userList[0]);
            }
            return null;
        }
        public bool CheckIfUserExists(NHibernateLibrary.Entities.ProfileUser profileUser)
        {

            Boolean userExists = false;
            var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.Username == profileUser.Username);
            if (query != null && query.RowCount() > 0)
            {
                userExists = true;
            }
            
            return userExists;
        }

        #endregion


        public bool RegisterUser(NHibernateLibrary.Entities.ProfileUser PUser)
        {
            try
            {
                //var query = CurrentSession.QueryOver<ProfileUser>().OrderBy(p => p.Id).Desc.Take(1);
                //PUser.Id = query.List<NHibernateLibrary.Entities.ProfileUser>()[0].Id + 1;
                Create(PUser);

            }
            catch (Exception exception)
            {
                throw new DataLayerException(exception.Message,exception.InnerException);
            } return true;
        }
        public bool UpdateUserProfile(NHibernateLibrary.Entities.ProfileUser PUser)
        {
            try
            {
                SaveOrUpdate(PUser);

            }
            catch (Exception exception)
            {
                throw new DataLayerException(exception.Message, exception.InnerException);
            } return true;
        }
        public NHibernateLibrary.Entities.ProfileUser GetUserProfile(NHibernateLibrary.Entities.ProfileUser profileUser)
        {
           
            IList<NHibernateLibrary.Entities.ProfileUser> userList;
            var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.Username == profileUser.Username);

            if (query != null && query.RowCount() > 0)
            {
                userList = query.List<NHibernateLibrary.Entities.ProfileUser>();

                return Common.Utils<ProfileUser>.TrimStringProperties(userList[0]);
            }
            return null;
        }

        public NHibernateLibrary.Entities.ProfileUser GetUserProfileByEMail(NHibernateLibrary.Entities.ProfileUser profileUser)
        {

            IList<NHibernateLibrary.Entities.ProfileUser> userList;
            var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.Email == profileUser.Email);

            if (query != null && query.RowCount() > 0)
            {
                userList = query.List<NHibernateLibrary.Entities.ProfileUser>();

                return Common.Utils<ProfileUser>.TrimStringProperties(userList[0]);
            }
            return null;
        }



        public IList<ProfileUser> GetGators(Criterion Criterion, String Value)
        {

            IList<ProfileUser> userProfiles;

            //ProfileUser[] userProfiles = null;
            try
            {
                if (Criterion == Criterion.Location)
                {
                    var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.PrevLocation == Value);
                    userProfiles = query.List<NHibernateLibrary.Entities.ProfileUser>();
                }
                else if (Criterion == Criterion.Education)
                {
                    var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.PrevEducation == Value);
                    userProfiles = query.List<NHibernateLibrary.Entities.ProfileUser>();
                }
                else
                {
                    var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.PrevWork == Value);
                    userProfiles = query.List<NHibernateLibrary.Entities.ProfileUser>();
                }
                
                //userProfiles = new String[myList.Count()];
                //for (int i = 0; i < myList.Count(); i++)
                //{
                //    userProfiles[i] = myList[i].ToString();
                //}
            }
            catch (Exception exception)
            {
                throw new DataLayerException(exception.Message, exception.InnerException);
            }
            return Common.Utils<ProfileUser>.TrimStringProperties(userProfiles);
            //return userProfiles;
        }
    }
}
