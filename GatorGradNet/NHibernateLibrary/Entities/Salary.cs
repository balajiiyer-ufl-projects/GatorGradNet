using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Salary : BaseEntity<Int64>
    {
        //public virtual Company Company { get; set; }
        public virtual CompanyDesignation CompanyDesignationId { get; set; }
        public virtual float MinSalary { get; set; }
        public virtual float AvgSalary { get; set; }
        public virtual float MaxSalary { get; set; }

        public override bool Equals(object salary)
        {
            if (salary == null)
                return false;
            var instance = salary as Salary;
            if (instance == null)
                return false;
            if (MinSalary == instance.MinSalary && AvgSalary == instance.AvgSalary && MaxSalary == instance.MaxSalary && CompanyDesignationId==instance.CompanyDesignationId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyDesignationId + "|" + MinSalary + "|" + AvgSalary+"|" + MaxSalary).GetHashCode();
        }  
    }
}
