using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatorGradNet.BusinessLayer
{
    public class RecruitmentStatistics
    {
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
    }
}
