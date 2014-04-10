using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Recruitment : BaseEntity<Int64>
    {
        //public virtual int CompanyID { get; set; }
        //public virtual int DesignationID { get; set; }
        public virtual int Year { get; set; }
        public virtual int NoOfHires { get; set; }

        //public virtual Company Company { get; set; }
        public virtual CompanyDesignation CompanyDesignationId { get; set; }

        public override bool Equals(object recruitment)
        {
            if (recruitment == null)
                return false;
            var instance = recruitment as Recruitment;
            if (instance == null)
                return false;
            if (Year == instance.Year && NoOfHires == instance.Year && CompanyDesignationId==instance.CompanyDesignationId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyDesignationId+"|"+Year+"|"+NoOfHires).GetHashCode();
        }  
    }
}
