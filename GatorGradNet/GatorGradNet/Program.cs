using NHibernate;
using NHibernate.Linq;
using NHibernateLibrary;
using NHibernateLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatorGradNet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IList<Customer> myList;
            IList<Address> amyList;
            ISession session = NHibernateLibrary.Helper.NHibernateHelper.GetCurrentSession();

            ITransaction tx = session.BeginTransaction();
            ICriteria criteria = session.CreateCriteria(typeof(Customer));
            //myList= criteria.List<Customer>();
            IQuery query = session.CreateQuery("select c from Customer as c");
            myList = query.List<Customer>();

            ICriteria addCriteria = session.CreateCriteria(typeof(Address));
            IQuery aquery = session.CreateQuery("select a from Address as a");
            amyList=session.Query<Address>().ToList();
            //amyList = aquery.List<Address>();
            Console.WriteLine(myList.Count());
        }
    }
}
