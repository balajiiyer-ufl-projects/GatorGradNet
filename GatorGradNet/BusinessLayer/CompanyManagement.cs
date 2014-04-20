using NHibernateLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatorGradNet.BusinessLayer
{
    public class CompanyManagement
    {
        private static CompanyManagement instance = new CompanyManagement();

        CompanyManagement() { }

        public static CompanyManagement Instance()
        {
            return instance;
        }
        public IList<Company> GetCompanyList()
        {
            return DataAccessLayer.CompanyManagement.Instance().GetCompanyList();
        }
       
    }
}
