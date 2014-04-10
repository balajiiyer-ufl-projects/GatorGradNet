using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Company : BaseEntity<Int64>
    {
        //public virtual int CompanyID { get; set; }
        public virtual String CompanyName { get; set; }
        public virtual String Description { get; set; }
        public virtual String URL { get; set; }
        public virtual int NoOfEmps { get; set; }
        public virtual String HQLocation { get; set; }

        public virtual Iesi.Collections.Generic.ISet<CompanyDesignation> Designations { get; set; }
        public virtual Iesi.Collections.Generic.ISet<CompanyIndustry> Industries { get; set; }
        //public virtual Location LocationName { get; set; }
        //public virtual Recruitment Recruitment { get; set; }
        //public virtual Salary Salary { get; set; }
        public virtual void AddDesignation(CompanyDesignation designation)
        {
            designation.CompanyId = this;
            Designations.Add(designation);
        }

        public virtual void AddIndustry(CompanyIndustry industry)
        {
            industry.CompanyId = this;
            Industries.Add(industry);
        }
     }
    
}

