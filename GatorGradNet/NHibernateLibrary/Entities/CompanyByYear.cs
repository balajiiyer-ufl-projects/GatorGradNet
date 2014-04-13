using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class CompanyByYear
    {
        //public virtual int CompanyID { get; set; }
        //public virtual int DesignationID { get; set; }
        public virtual int Year { get; set; }
        public virtual int TotalHires { get; set; }

        public virtual Int64 CompanyID { get; set; }

        //public virtual Company Company { get; set; }
        //public virtual CompanyDesignation CompanyDesignationId { get; set; }

        public override bool Equals(object companybyyear)
        {
            if (companybyyear == null)
                return false;
            var instance = companybyyear as CompanyByYear;
            if (instance == null)
                return false;
            if (Year == instance.Year && TotalHires == instance.Year && CompanyID == instance.CompanyID)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyID + "|" + Year + "|" + TotalHires).GetHashCode();
        }  
    }
}
