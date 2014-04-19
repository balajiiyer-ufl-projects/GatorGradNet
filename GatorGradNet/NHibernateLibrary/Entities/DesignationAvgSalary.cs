using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class DesignationAvgSalary
    {
        //public virtual Company Company { get; set; }
        //public virtual CompanyDesignation CompanyDesignationId { get; set; }
        //public virtual float MinSalary { get; set; }
        public virtual string Designation { get; set; }
        public virtual float AvgSalary { get; set; }
        //public virtual float MaxSalary { get; set; }

        public override bool Equals(object designationavgsalary)
        {
            if (designationavgsalary == null)
                return false;
            var instance = designationavgsalary as DesignationAvgSalary;
            if (instance == null)
                return false;
            if (Designation == instance.Designation && AvgSalary == instance.AvgSalary)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + Designation + "|" + AvgSalary + "|").GetHashCode();
        }  
    }
}
