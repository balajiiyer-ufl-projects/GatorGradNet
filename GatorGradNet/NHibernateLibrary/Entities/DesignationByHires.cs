using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class DesignationByHires
    {
        //public virtual int CompanyID { get; set; }
        //public virtual int DesignationID { get; set; }
        public virtual string Designation { get; set; }
        public virtual int NoOfHires { get; set; }

        //public virtual Company Company { get; set; }

        public override bool Equals(object designationbyhires)
        {
            if (designationbyhires == null)
                return false;
            var instance = designationbyhires as DesignationByHires;
            if (instance == null)
                return false;
            if (Designation == instance.Designation && NoOfHires == instance.NoOfHires)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|"+Designation+"|"+NoOfHires).GetHashCode();
        }  
    }
}
