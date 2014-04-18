using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class CompanyTotalHires
    {
        //public virtual int CompanyID { get; set; }
        //public virtual int DesignationID { get; set; }
        public virtual int NoOfHires { get; set; }
        public virtual string CompanyName { get; set; }

        //public virtual Company Company { get; set; }
        //public virtual CompanyDesignation CompanyDesignationId { get; set; }

        public override bool Equals(object companytotalhires)
        {
            if (companytotalhires == null)
                return false;
            var instance = companytotalhires as CompanyTotalHires;
            if (instance == null)
                return false;
            if (NoOfHires == instance.NoOfHires && CompanyName == instance.CompanyName)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + NoOfHires + "|" + CompanyName).GetHashCode();
        }  
    }
}
