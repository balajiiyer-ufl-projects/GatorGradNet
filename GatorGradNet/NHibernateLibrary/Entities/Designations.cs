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
        public virtual int DesignationID { get; set; }
        public virtual String Designation { get; set; }
    }
}
