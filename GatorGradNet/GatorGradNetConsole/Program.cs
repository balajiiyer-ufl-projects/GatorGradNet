using NHibernate;
using NHibernate.Linq;
using NHibernateLibrary;
using NHibernateLibrary;
using NHibernateLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using System.IO;
using System.Collections;

namespace GatorGradNet
{
    class Program
    {
        static void Main(string[] args)
        {

            //IList<Customer> myList;
            IList<Address> amyList;
            ISession session = NHibernateLibrary.Helper.NHibernateHelper.GetCurrentSession();

            ITransaction tx = session.BeginTransaction();
            ICriteria criteria = session.CreateCriteria(typeof(Customer));
            //myList= criteria.List<Customer>();
            //IQuery query = session.CreateQuery("select c from Customer as c");
            //myList = query.List<Customer>();

            //ICriteria addCriteria = session.CreateCriteria(typeof(Address));
            //IQuery aquery = session.CreateQuery("select a from Address as a");
            //amyList = session.Query<Address>().ToList();
           //FileInfo fi = new FileInfo("C:\\temp.txt");
            // Actually create the file.
            //FileStream fs = fi.Create();
            //fs.Close();
            
             // Delete the file.
            //fi.Delete();
            //Utils<Address>.WriteDelimitedFile(amyList, fi, "\t");
               // Modify the file as required, and then close the file.
            //fs.Close();
            //amyList = aquery.List<Address>();
            //Console.WriteLine(amyList.Count());
            //Int64 id = 294;
            //ProfileUser user = session.Get<ProfileUser>(id);
            //user.FirstName = "ManipalReddy";
            //NHibernateLibrary.Helper.NHibernateHelper.GetCurrentSession().Flush();
            //DataAccessLayer.UserManagement.Instance().UpdateUserProfile(user);
            //new GatorGradNet.DataAccessLayer.RecruitmentStatistics().StatisticsByYear("amazon");
            //ProfileUser user1 = session.Get<ProfileUser>(id);
            Random random = new Random();
            int code = random.Next(1000, 100000000);
            MailProvider.Instance().MailSend(code, "b.manipalreddy@gmail.com", "Manipal");

            Console.ReadLine();
        }
    }
}