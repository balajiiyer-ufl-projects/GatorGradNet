using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Company
    {
        public virtual int CompanyID { get; set; }
        public virtual String CompanyName { get; set; }
        public virtual String Description { get; set; }
        public virtual String URL { get; set; }
        public virtual int NoOfEmps { get; set; }
        public virtual String HQLocation { get; set; }
    }
    
}

