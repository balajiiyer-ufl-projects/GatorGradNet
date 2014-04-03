using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Designations : BaseEntity<Int64>
    {
        public virtual String Designation { get; set; }

        //public virtual Location Location { get; set; }

        //public virtual Recruitment Recruitment { get; set; }
        //public virtual Salary Salary { get; set; }
    }
}
