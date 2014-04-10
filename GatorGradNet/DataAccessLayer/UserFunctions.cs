using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateLibrary.Entities;
using NHibernate;

namespace GatorGradNet.DataAccessLayer
{
    public class UserFunctions
    {
        public bool LoginCheck(NHibernateLibrary.Entities.ProfileUser PUser)
        {
            NHibernateLibrary.NHibernateHelper nbh;
            IList<NHibernateLibrary.Entities.ProfileUser> myList;

            nbh = new NHibernateLibrary.NHibernateHelper();
            ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();

            ITransaction tx = session.BeginTransaction();
            ICriteria criteria = session.CreateCriteria("ProfileUser");

            IQuery query = session.CreateQuery("select * from ProfileUser as p where p.Username = '"+PUser.Username+"'");
            myList = query.List<NHibernateLibrary.Entities.ProfileUser>();
            Console.WriteLine(myList.Count());
            if (myList.Count == 0)
            {
                return false;
            }
            if (myList[0].Password == PUser.Password)
            {
                return true;
            }
            return false;
        }
        public bool UserExistsOrNot(NHibernateLibrary.Entities.ProfileUser PUser)
        {
            NHibernateLibrary.NHibernateHelper nbh;
            IList<NHibernateLibrary.Entities.ProfileUser> myList;

            nbh = new NHibernateLibrary.NHibernateHelper();
            ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();

            ITransaction tx = session.BeginTransaction();
            ICriteria criteria = session.CreateCriteria("ProfileUser");

            IQuery query = session.CreateQuery("select * from ProfileUser as p where p.Username = '" + PUser.Username + "'");
            myList = query.List<NHibernateLibrary.Entities.ProfileUser>();
            Console.WriteLine(myList.Count());
            if (myList.Count == 0)
            {
                return false;
            }
            return true;
        }
        public bool RegisterUser(NHibernateLibrary.Entities.ProfileUser PUser)
        {
            NHibernateLibrary.NHibernateHelper nbh;
            //IList<NHibernateLibrary.Entities.ProfileUser> myList;

            nbh = new NHibernateLibrary.NHibernateHelper();
            ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();
            ITransaction tx = session.BeginTransaction();
            session.Save(PUser);
            return true;
        }
    }
}
