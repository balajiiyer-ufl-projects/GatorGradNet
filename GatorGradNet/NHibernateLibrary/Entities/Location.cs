using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Location : BaseEntity<Int64>
    {
        //public virtual int CompanyID { get; set; }
        //public virtual int DesignationID { get; set; }
        public virtual String LocationName { get; set; }
        public virtual CompanyDesignation CompanyDesignationId { get; set; }
        //public virtual Company Company { get; set; }

        //public virtual Designations Designation { get; set; }

        public override bool Equals(object location)
        {
            if (location == null)
                return false;
            var instance = location as Location;
            if (instance == null)
                return false;
            if (LocationName == instance.LocationName && CompanyDesignationId==instance.CompanyDesignationId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyDesignationId+"|"+ LocationName).GetHashCode();
        }  

    }
}
