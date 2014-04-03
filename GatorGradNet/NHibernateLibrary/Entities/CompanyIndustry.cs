using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class CompanyIndustry : BaseEntity<Int64>
    {
        //public virtual int CompanyID { get; set; }
        public virtual String Industry { get; set; }
        public virtual Company CompanyId { get; set; }

        public override bool Equals(object industry)
        {
            if (industry == null)
                return false;
            var instance = industry as CompanyIndustry;
            if (instance == null)
                return false;
            if (Industry == instance.Industry && CompanyId==instance.CompanyId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyId + "|" + Industry).GetHashCode();
        }  

    }
}
