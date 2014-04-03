using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class CompanyDesignation : BaseEntity<Int64>
    {
        //public virtual int CompanyID { get; set; }
        public virtual String Designation { get; set; }

        public virtual Company CompanyId { get; set; }

       // public virtual Location Location { get; set; }

        //public virtual Salary Salary { get; set; }

       // public virtual Recruitment Recruitment { get; set; }

        public virtual Iesi.Collections.Generic.ISet<Location> Locations { get; set; }

        public virtual Iesi.Collections.Generic.ISet<Recruitment> Recruitments { get; set; }

        public virtual Iesi.Collections.Generic.ISet<Salary> Salaries { get; set; }
        public virtual void AddLocation(Location location)
        {
            location.CompanyDesignationId = this;
            Locations.Add(location);
        }

        public virtual void AddRecruitmentData(Recruitment recruitment)
        {
            recruitment.CompanyDesignationId = this;
            Recruitments.Add(recruitment);
        }

        public virtual void AddSalaryData(Salary salary)
        {
            salary.CompanyDesignationId = this;
            Salaries.Add(salary);
        }

        public override bool Equals(object companyDesignation)
        {
            if (companyDesignation == null)
                return false;
            var instance = companyDesignation as CompanyDesignation;
            if (instance == null)
                return false;
            if (Designation == instance.Designation && CompanyId==instance.CompanyId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + CompanyId +
               "|" + Designation).GetHashCode();
        }  

    }
}
