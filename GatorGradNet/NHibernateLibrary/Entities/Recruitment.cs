using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Recruitment
    {
        public virtual int CompanyID { get; set; }
        public virtual int DesignationID { get; set; }
        public virtual int Year { get; set; }
        public virtual int NoOfHires { get; set; }
    }
}
