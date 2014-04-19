using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class CompanySalary
    {
        //public virtual Company Company { get; set; }
        public virtual String CompanyName { get; set; }
        public virtual Int64 CompanyID { get; set; }
        public virtual Int64 DesignationID { get; set; }
        public virtual float AvgSalary { get; set; }

        public override bool Equals(object companysalary)
        {
            if (companysalary == null)
                return false;
            var instance = companysalary as CompanySalary;
            if (instance == null)
                return false;
            if (CompanyName == instance.CompanyName && AvgSalary == instance.AvgSalary && CompanyID == instance.CompanyID && DesignationID == instance.DesignationID)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyName + "|" + CompanyID + "|" + DesignationID + "|" + AvgSalary + "|").GetHashCode();
        }  
    }
}
