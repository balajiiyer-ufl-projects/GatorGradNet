using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class MaxRecruitmentEachYear
    {
        public virtual string CompanyName { get; set; }
        //public virtual int DesignationID { get; set; }
        public virtual int Year { get; set; }
        public virtual int NoOfHires { get; set; }

        //public virtual Company Company { get; set; }

        public override bool Equals(object maxrecruitmenteachyear)
        {
            if (maxrecruitmenteachyear == null)
                return false;
            var instance = maxrecruitmenteachyear as MaxRecruitmentEachYear;
            if (instance == null)
                return false;
            if (Year == instance.Year && NoOfHires == instance.Year && CompanyName == instance.CompanyName)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyName + "|"+Year+"|"+NoOfHires).GetHashCode();
        }  
    }
}
