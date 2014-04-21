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
using GatorGradNet.BusinessLayer;

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

            //new GatorGradNet.DataAccessLayer.RecruitmentStatistics().StatisticsByYear("microsoft");
            //new GatorGradNet.DataAccessLayer.RecruitmentStatistics().CompanyNameSalary("software development engineer");
            //new GatorGradNet.DataAccessLayer.RecruitmentStatistics().CompanyTotalHires();
            //new GatorGradNet.DataAccessLayer.RecruitmentStatistics().DesignationAverageSalary();
            //new GatorGradNet.DataAccessLayer.RecruitmentStatistics().ShowDesignationByHires();
            //new GatorGradNet.DataAccessLayer.RecruitmentStatistics().ShowMaxRecruitmentEachYear(2012);
            //new GatorGradNet.DataAccessLayer.RecruitmentStatistics().ShowSalaryVersusHire();
            //IList<Company> coList=BusinessLayer.CompanyManagement.Instance().GetCompanyList();


            IList<ProfileUser> userList=BusinessLayer.UserManagement.Instance().GetGatorsByLocation("India");

            Console.ReadLine();
        }
    }
}