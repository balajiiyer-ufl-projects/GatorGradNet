using NHibernateLibrary.Entities;
using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatorGradNet.DataAccessLayer
{
    public class CompanyManagement : BaseDataAccess<Company, Int64>
    {
        private static CompanyManagement companyManagementInstance = new CompanyManagement();

        public static CompanyManagement Instance()
        {
            return companyManagementInstance;
        }
        /// <summary>
        /// Get company details by name
        /// </summary>
        /// <param name="company">The company info</param>
        /// <returns></returns>
        public Company GetCompanyByName(Company company)
        {
            var query = CurrentSession.QueryOver<Company>().Where(c => c.CompanyName == company.CompanyName);
            if (query != null && query.RowCount() > 0)
            {
               company= query.List<NHibernateLibrary.Entities.Company>().FirstOrDefault();
            }

            return company;
        }


    }
}
