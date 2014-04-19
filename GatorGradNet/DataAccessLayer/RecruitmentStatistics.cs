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

        private static RecruitmentStatistics recStatsInstance = new RecruitmentStatistics();

        public static RecruitmentStatistics Instance()
        {

            return recStatsInstance;
        }

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
        public void StatisticsByYear(String CompanyName, String FileLocation)
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
            
            FileInfo fi = new FileInfo(FileLocation);
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

        public void CompanyNameSalary(String Designation, String FileLocation)
        {
            IList<NHibernateLibrary.Entities.Designations> designationList = null;
            var tempquery = CurrentSession.QueryOver<Designations>().Where(designations => designations.Designation == Designation);
            Int64 designationID;
            if (tempquery != null && tempquery.RowCount() > 0)
            {
                designationList = tempquery.List<NHibernateLibrary.Entities.Designations>();
                designationID = designationList[0].Id;
                //Console.WriteLine(designationID + " dID");
            }
            else
            {
                return;
            }
            IList<CompanySalary> companysalaryList = null;
            //var query = CurrentSession.QueryOver<Recruitment>().Where(recruitment => recruitment.CompanyDesignationId.CompanyId.Id == companyID).SelectList(list => list.SelectGroup(recruitment => recruitment.Year).SelectSum(recruitment => recruitment.NoOfHires));
            var query = CurrentSession.QueryOver<CompanySalary>().Where(companysalary => companysalary.DesignationID == designationID);//.Select(companybyyear => companybyyear.Year, companybyyear => companybyyear.TotalHires);
            companysalaryList = query.List<CompanySalary>();

            //string q=query.ToString();
            //int row = query.RowCount();

            FileInfo fi = new FileInfo(FileLocation);
            // Actually create the file.
            FileStream fs = fi.Create();
            fs.Close();

            // Delete the file.
            //fi.Delete();
            Utils<CompanySalary>.WriteDelimitedFile(companysalaryList, fi, "\t", "CompanyID", "DesignationID");
            // Modify the file as required, and then close the file.
            fs.Close();
            //amyList = aquery.List<Address>();
            Console.WriteLine(companysalaryList.Count());

        }
        public void CompanyTotalHires(String FileLocation)
        {
            IList<CompanyTotalHires> companysalaryList = null;
            //var query = CurrentSession.QueryOver<Recruitment>().Where(recruitment => recruitment.CompanyDesignationId.CompanyId.Id == companyID).SelectList(list => list.SelectGroup(recruitment => recruitment.Year).SelectSum(recruitment => recruitment.NoOfHires));
            var query = CurrentSession.QueryOver<CompanyTotalHires>().OrderBy(cth => cth.NoOfHires).Desc;
            companysalaryList = query.List<CompanyTotalHires>();

            //string q=query.ToString();
            //int row = query.RowCount();

            FileInfo fi = new FileInfo(FileLocation);
            // Actually create the file.
            FileStream fs = fi.Create();
            fs.Close();

            // Delete the file.
            //fi.Delete();
            Utils<CompanyTotalHires>.WriteDelimitedFile(companysalaryList, fi, "\t");
            // Modify the file as required, and then close the file.
            fs.Close();
            //amyList = aquery.List<Address>();
            Console.WriteLine(companysalaryList.Count());

        }


        public IList<CompanyTotalHires> CompanyTotalHires()
        {
            IList<CompanyTotalHires> companysalaryList = null;
            //var query = CurrentSession.QueryOver<Recruitment>().Where(recruitment => recruitment.CompanyDesignationId.CompanyId.Id == companyID).SelectList(list => list.SelectGroup(recruitment => recruitment.Year).SelectSum(recruitment => recruitment.NoOfHires));
            var query = CurrentSession.QueryOver<CompanyTotalHires>().OrderBy(cth => cth.NoOfHires).Desc.Take(10);
            companysalaryList = query.List<CompanyTotalHires>();
            return companysalaryList;

        }
        public void DesignationAverageSalary(String FileLocation)
        {
            IList<DesignationAvgSalary> dasList = null;
            //var query = CurrentSession.QueryOver<Recruitment>().Where(recruitment => recruitment.CompanyDesignationId.CompanyId.Id == companyID).SelectList(list => list.SelectGroup(recruitment => recruitment.Year).SelectSum(recruitment => recruitment.NoOfHires));
            var query = CurrentSession.QueryOver<DesignationAvgSalary>().OrderBy(das => das.AvgSalary).Desc;
            dasList = query.List<DesignationAvgSalary>();

            //string q=query.ToString();
            //int row = query.RowCount();

            FileInfo fi = new FileInfo(FileLocation);
            // Actually create the file.
            FileStream fs = fi.Create();
            fs.Close();

            // Delete the file.
            //fi.Delete();
            Utils<DesignationAvgSalary>.WriteDelimitedFile(dasList, fi, "\t");
            // Modify the file as required, and then close the file.
            fs.Close();
            //amyList = aquery.List<Address>();
            Console.WriteLine(dasList.Count());

        }
        public void ShowDesignationByHires(String FileLocation)
        {
            IList<DesignationByHires> dbhList = null;
            //var query = CurrentSession.QueryOver<Recruitment>().Where(recruitment => recruitment.CompanyDesignationId.CompanyId.Id == companyID).SelectList(list => list.SelectGroup(recruitment => recruitment.Year).SelectSum(recruitment => recruitment.NoOfHires));
            var query = CurrentSession.QueryOver<DesignationByHires>().OrderBy(dbh => dbh.NoOfHires).Desc;
            dbhList = query.List<DesignationByHires>();

            //string q=query.ToString();
            //int row = query.RowCount();

            FileInfo fi = new FileInfo(FileLocation);
            // Actually create the file.
            FileStream fs = fi.Create();
            fs.Close();

            // Delete the file.
            //fi.Delete();
            Utils<DesignationByHires>.WriteDelimitedFile(dbhList, fi, "\t");
            // Modify the file as required, and then close the file.
            fs.Close();
            //amyList = aquery.List<Address>();
            Console.WriteLine(dbhList.Count());

        }
        public void ShowMaxRecruitmentEachYear(int year, String FileLocation)
        {
            IList<MaxRecruitmentEachYear> mreyList = null;
            //var query = CurrentSession.QueryOver<Recruitment>().Where(recruitment => recruitment.CompanyDesignationId.CompanyId.Id == companyID).SelectList(list => list.SelectGroup(recruitment => recruitment.Year).SelectSum(recruitment => recruitment.NoOfHires));
            var query = CurrentSession.QueryOver<MaxRecruitmentEachYear>().Where(mrey => mrey.Year == year).OrderBy(mrey => mrey.NoOfHires).Desc;
            mreyList = query.List<MaxRecruitmentEachYear>();

            //string q=query.ToString();
            //int row = query.RowCount();

            FileInfo fi = new FileInfo(FileLocation);
            // Actually create the file.
            FileStream fs = fi.Create();
            fs.Close();

            // Delete the file.
            //fi.Delete();
            Utils<MaxRecruitmentEachYear>.WriteDelimitedFile(mreyList, fi, "\t");
            // Modify the file as required, and then close the file.
            fs.Close();
            //amyList = aquery.List<Address>();
            Console.WriteLine(mreyList.Count());

        }
        public void ShowSalaryVersusHire(String FileLocation)
        {
            IList<SalaryVersusHire> svhList = null;
            //var query = CurrentSession.QueryOver<Recruitment>().Where(recruitment => recruitment.CompanyDesignationId.CompanyId.Id == companyID).SelectList(list => list.SelectGroup(recruitment => recruitment.Year).SelectSum(recruitment => recruitment.NoOfHires));
            var query = CurrentSession.QueryOver<SalaryVersusHire>().OrderBy(svh => svh.AvgSalary).Asc;
            svhList = query.List<SalaryVersusHire>();

            //string q=query.ToString();
            //int row = query.RowCount();

            FileInfo fi = new FileInfo(FileLocation);
            // Actually create the file.
            FileStream fs = fi.Create();
            fs.Close();

            // Delete the file.
            //fi.Delete();
            Utils<SalaryVersusHire>.WriteDelimitedFile(svhList, fi, "\t");
            // Modify the file as required, and then close the file.
            fs.Close();
            //amyList = aquery.List<Address>();
            Console.WriteLine(svhList.Count());

        }
    }
}
