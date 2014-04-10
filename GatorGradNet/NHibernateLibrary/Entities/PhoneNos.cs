using NHibernateLibrary.Entities;
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
        //public virtual int UserID { get; set; }
        public virtual String PhoneNo { get; set; }
        public virtual ProfileUser UserId { get; set; }

        public override bool Equals(object phoneNo)
        {
            if (phoneNo == null)
                return false;
            var instance = phoneNo as PhoneNos;
            if (instance == null)
                return false;
            if (PhoneNo == instance.PhoneNo && UserId==instance.UserId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + UserId + "|" + PhoneNo).GetHashCode();
        }  
    }
}
