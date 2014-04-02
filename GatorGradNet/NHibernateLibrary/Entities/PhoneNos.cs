using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class PhoneNos : BaseEntity<Int64>
    {
        public virtual int UserID { get; set; }
        public virtual String PhoneNo { get; set; }
    }
}
