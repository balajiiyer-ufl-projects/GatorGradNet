using NHibernate;
using NHibernateLibrary;
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
            ISession session = NHibernateLibrary.NHibernateHelper.GetCurrentSession();

            ITransaction tx = session.BeginTransaction();
            //ICriteria criteria = session.CreateCriteria("Customers");
            //myList= criteria.List<Customer>();
            IQuery query = session.CreateQuery("select c from Customer as c");
            myList = query.List<Customer>();
            Console.WriteLine(myList.Count());
        }
    }
}
