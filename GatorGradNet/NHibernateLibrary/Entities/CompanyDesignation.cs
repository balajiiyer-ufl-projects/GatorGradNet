using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class CompanyDesignation
    {
        public virtual int CompanyID { get; set; }
        public virtual String Designation { get; set; }
    }
}
