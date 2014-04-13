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
using System.IO;

namespace GatorGradNet.DataAccessLayer
{
    public class RecruitmentStatistics : BaseDataAccess<Recruitment, Int64>
    {
/*        public String[] GetCompaniesBySalary()
        {
            String[] Companies;
            IList<NHibernateLibrary.Entities.Company> userList = null;
            var query = CurrentSession.QueryOver<Company>().JoinQueryOver<Salary>.Where(

            if (query != null && query.RowCount() > 0)
            {
                userList = query.List<NHibernateLibrary.Entities.ProfileUser>();

                //if (userList[0].Password != profileUser.Password)
                //{
                //    userList[0] = null;
                //}
                //userList[0] = profileUser;
                return userList[0];
            }

        }
 */
        public void StatisticsByYear(String CompanyName)
        {
            IList<NHibernateLibrary.Entities.Company> companyList = null;
            var tempquery = CurrentSession.QueryOver<Company>().Where(company => company.CompanyName == CompanyName);
            Int64 companyID;
            if (tempquery != null && tempquery.RowCount() > 0)
            {
                companyList = tempquery.List<NHibernateLibrary.Entities.Company>();
                companyID = companyList[0].Id;
            }
            else
            {
                return;
            }
            IList<CompanyByYear> recruitmentList = null;
            //var query = CurrentSession.QueryOver<Recruitment>().Where(recruitment => recruitment.CompanyDesignationId.CompanyId.Id == companyID).SelectList(list => list.SelectGroup(recruitment => recruitment.Year).SelectSum(recruitment => recruitment.NoOfHires));
            var query = CurrentSession.QueryOver<CompanyByYear>().Where(companybyyear => companybyyear.CompanyID == companyID);//.Select(companybyyear => companybyyear.Year, companybyyear => companybyyear.TotalHires);
            recruitmentList = query.List<CompanyByYear>();
           
            //string q=query.ToString();
            //int row = query.RowCount();
            
            FileInfo fi = new FileInfo("C:\\data.txt");
            // Actually create the file.
            FileStream fs = fi.Create();
            fs.Close();

            // Delete the file.
            //fi.Delete();
            Utils<CompanyByYear>.WriteDelimitedFile(recruitmentList, fi, "\t", "CompanyID");
            // Modify the file as required, and then close the file.
            fs.Close();
            //amyList = aquery.List<Address>();
            Console.WriteLine(recruitmentList.Count());

        }
    }
}
