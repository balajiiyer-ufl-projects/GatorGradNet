using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Salary
    {
        public virtual int CompanyID { get; set; }
        public virtual int DesignationID { get; set; }
        public float MinSalary { get; set; }
        public float AvgSalary { get; set; }
        public float MaxSalary { get; set; }
    }
}
