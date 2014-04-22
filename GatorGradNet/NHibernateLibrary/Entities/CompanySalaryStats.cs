using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateLibrary.Helper;

namespace NHibernateLibrary.Entities
{
    public class CompanySalaryStats
    {
        //public virtual Company Company { get; set; }
        public virtual String CompanyName { get; set; }
        public virtual Int64 CompanyID { get; set; }
        
        public virtual float AvgSalary { get; set; }

        public virtual float MaxSalary { get; set; }

        public virtual float MinSalary { get; set; }

        public override bool Equals(object companySalaryStats)
        {
            if (companySalaryStats == null)
                return false;
            var instance = companySalaryStats as CompanySalaryStats;
            if (instance == null)
                return false;
            if (CompanyName == instance.CompanyName && AvgSalary == instance.AvgSalary && CompanyID == instance.CompanyID && MaxSalary == instance.MaxSalary &&MinSalary==instance.MinSalary)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyName + "|" + CompanyID + "|" + MinSalary + "|" + AvgSalary + "|"+MaxSalary).GetHashCode();
        }  
    }
}
