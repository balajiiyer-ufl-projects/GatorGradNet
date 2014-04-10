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
                return userList[0];
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
            //NHibernateLibrary.NHibernateHelper nbh;
            IList<NHibernateLibrary.Entities.ProfileUser> userList;

            //nbh = new NHibernateLibrary.NHibernateHelper();
            //ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();

            //ITransaction tx = CurrentSession.BeginTransaction();
            //ICriteria criteria = CurrentSession.CreateCriteria("ProfileUser");

//            IQuery query = CurrentSession.CreateQuery("select * from ProfileUser as p where p.Username = '" + PUser.Username + "'");
            var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.Username == profileUser.Username);

            if (query != null && query.RowCount() > 0)
            {
                userList = query.List<NHibernateLibrary.Entities.ProfileUser>();

                return userList[0];
            }
            return null;
        }
        /*        public String[] GetUsersByLocation(String Location)
                {
                    NHibernateLibrary.NHibernateHelper nbh;
                    IList<NHibernateLibrary.Entities.ProfileUser> myList;

                    nbh = new NHibernateLibrary.NHibernateHelper();
                    ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();

                    ITransaction tx = session.BeginTransaction();
                    ICriteria criteria = session.CreateCriteria("ProfileUser");

                    IQuery query = session.CreateQuery("select p.Username from ProfileUser as p where p.PrevLocation = '" + Location + "'");
                    myList = query.List<NHibernateLibrary.Entities.ProfileUser>();
                    //Console.WriteLine(myList.Count());
                    String[] Usernames = new String[myList.Count()];
                    for (int i = 0; i < myList.Count(); i++)
                    {
                        Usernames[i] = myList[i].ToString();
                    }
                    return Usernames;
                }
         */
        
        public String[] GetGators(Criterion Criterion, String Value)
        {
            //NHibernateLibrary.NHibernateHelper nbh;
            IList<NHibernateLibrary.Entities.ProfileUser> myList;

            //nbh = new NHibernateLibrary.NHibernateHelper();
            //ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();

            //ITransaction tx = CurrentSession.BeginTransaction();
            //ICriteria criteria = CurrentSession.CreateCriteria("ProfileUser");

            //IQuery query = CurrentSession.CreateQuery("select p.Username from ProfileUser as p where p." + Criterion + " = '" + Value + "'");
            //var query;
            String[] Usernames = null;
            try
            {
                if (Criterion == Criterion.Location)
                {
                    var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.PrevLocation == Value);
                    myList = query.List<NHibernateLibrary.Entities.ProfileUser>();
                }
                else if (Criterion == Criterion.Education)
                {
                    var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.PrevEducation == Value);
                    myList = query.List<NHibernateLibrary.Entities.ProfileUser>();
                }
                else
                {
                    var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.PrevWork == Value);
                    myList = query.List<NHibernateLibrary.Entities.ProfileUser>();
                }
                //Console.WriteLine(myList.Count());
                Usernames = new String[myList.Count()];
                for (int i = 0; i < myList.Count(); i++)
                {
                    Usernames[i] = myList[i].ToString();
                }
            }
            catch (DataLayerException)
            {

            }
            return Usernames;
        }
    }
}
