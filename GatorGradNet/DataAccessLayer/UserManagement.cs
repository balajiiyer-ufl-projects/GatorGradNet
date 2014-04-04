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
                userList[0] = profileUser;
                
            }
            return userList[0];
        }
        public bool CheckIfUserExists(NHibernateLibrary.Entities.ProfileUser profileUser)
        {
            //NHibernateLibrary.NHibernateHelper nbh;
            Boolean userExists = false;
            //IList<NHibernateLibrary.Entities.ProfileUser> userList=null;
            var query = CurrentSession.QueryOver<ProfileUser>().Where(user => user.Username == profileUser.Username);
            if (query != null && query.RowCount() > 0)
            {
                userExists = true;
                //userList = query.List<NHibernateLibrary.Entities.ProfileUser>();
                //Console.WriteLine(userList.Count());
                
            }
            
            return userExists;
        }

        #endregion


        public bool RegisterUser(NHibernateLibrary.Entities.ProfileUser PUser)
        {
            try
            {
                Create(PUser);

            }
            catch (DataLayerException)
            {

                throw;
            } return true;
        }
        public bool UpdateUserProfile(NHibernateLibrary.Entities.ProfileUser PUser)
        {
            try
            {
                SaveOrUpdate(PUser);

            }
            catch (DataLayerException)
            {

                throw;
            } return true;
        }
        public NHibernateLibrary.Entities.ProfileUser GetUserProfile(NHibernateLibrary.Entities.ProfileUser PUser)
        {
            //NHibernateLibrary.NHibernateHelper nbh;
            IList<NHibernateLibrary.Entities.ProfileUser> myList;

            //nbh = new NHibernateLibrary.NHibernateHelper();
            //ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();

            ITransaction tx = CurrentSession.BeginTransaction();
            ICriteria criteria = CurrentSession.CreateCriteria("ProfileUser");

            IQuery query = CurrentSession.CreateQuery("select * from ProfileUser as p where p.Username = '" + PUser.Username + "'");
            myList = query.List<NHibernateLibrary.Entities.ProfileUser>();
            Console.WriteLine(myList.Count());
            if (myList.Count == 0)
            {
                return null;
            }
            return myList[0];
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
        public String[] GetGatorsBy(String Criterion, String Value)
        {
            //NHibernateLibrary.NHibernateHelper nbh;
            IList<NHibernateLibrary.Entities.ProfileUser> myList;

            //nbh = new NHibernateLibrary.NHibernateHelper();
            //ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();

            ITransaction tx = CurrentSession.BeginTransaction();
            ICriteria criteria = CurrentSession.CreateCriteria("ProfileUser");

            IQuery query = CurrentSession.CreateQuery("select p.Username from ProfileUser as p where p." + Criterion + " = '" + Value + "'");
            myList = query.List<NHibernateLibrary.Entities.ProfileUser>();
            //Console.WriteLine(myList.Count());
            String[] Usernames = new String[myList.Count()];
            for (int i = 0; i < myList.Count(); i++)
            {
                Usernames[i] = myList[i].ToString();
            }
            return Usernames;
        }
    }
}
