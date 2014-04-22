using NHibernateLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatorGradNet.BusinessLayer
{
    public class RecruitmentStatistics
    {
        private static RecruitmentStatistics instance = new RecruitmentStatistics();

        RecruitmentStatistics() { }

        public static RecruitmentStatistics Instance() {
            return instance;
        }
        public void StatisticsByYear(String CompanyName, String FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().StatisticsByYear(CompanyName, FileLocation);
        }

        public void CompanyNameSalary(String Designation, String FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().CompanyNameSalary(Designation, FileLocation);
        }
        public void CompanyTotalHires(String FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().CompanyTotalHires(FileLocation);
        }

        public IList<CompanyTotalHires> CompanyTotalHires()
        {
                    
           return DataAccessLayer.RecruitmentStatistics.Instance().CompanyTotalHires();
        }

        public void DesignationAverageSalary(String FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().DesignationAverageSalary(FileLocation);
        }
        public void ShowDesignationByHires(String FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().ShowDesignationByHires(FileLocation);
        }
        public void ShowMaxRecruitmentEachYear(int year, String FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().ShowMaxRecruitmentEachYear(year, FileLocation);
        }
        public void ShowSalaryVersusHire(String FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().ShowSalaryVersusHire(FileLocation);
        }

        public IList<CompanySalaryStats> GetTopTenCompaniesBySalary(string FileLocation)
        {
           return  DataAccessLayer.RecruitmentStatistics.Instance().GetTopTenCompaniesBySalary(FileLocation);
        }

        public void GetTopTenCompaniesByMinSalary(string FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().GetTopTenCompaniesByMinSalary(FileLocation);
        }

        public void GetTopTenCompaniesByMaxSalary(string FileLocation)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().GetTopTenCompaniesByMaxSalary(FileLocation);
        }

        public void GetSalaryByCompany(string FileLocation,string companyName)
        {
            DataAccessLayer.RecruitmentStatistics.Instance().GetSalaryByCompany(FileLocation,companyName);
        }
    }
}
