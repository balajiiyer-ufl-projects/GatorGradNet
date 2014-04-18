using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class SalaryVersusHire
    {
        //public virtual Company Company { get; set; }
        public virtual int NoOfHires { get; set; }
        public virtual float AvgSalary { get; set; }

        public override bool Equals(object salaryversushire)
        {
            if (salaryversushire == null)
                return false;
            var instance = salaryversushire as SalaryVersusHire;
            if (instance == null)
                return false;
            if (NoOfHires == instance.NoOfHires && AvgSalary == instance.AvgSalary)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + NoOfHires + "|" + AvgSalary+"|").GetHashCode();
        }  
    }
}
