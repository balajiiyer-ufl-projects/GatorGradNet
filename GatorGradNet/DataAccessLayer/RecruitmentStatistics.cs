using Common;
using NHibernateLibrary.Entities;
using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate.Transaction;
using System.Threading.Tasks;
using NHibernate;

namespace GatorGradNet.DataAccessLayer
{
    class RecruitmentStatistics : BaseDataAccess<Recruitment, Int64>
    {
/*        public String[] GetCompaniesBySalary()
        {
            String[] Companies;
            IList<NHibernateLibrary.Entities.Company> userList = null;
            var query = CurrentSession.QueryOver<Company>().JoinQueryOver<Salary>.Where(

            if (query != null && query.RowCount() > 0)
            {
                userList = query.List<NHibernateLibrary.Entities.ProfileUser>();

                //if (userList[0].Password != profileUser.Password)
                //{
                //    userList[0] = null;
                //}
                //userList[0] = profileUser;
                return userList[0];
            }

        }
 */
    }
}
