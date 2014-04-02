using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary
{
    public class Address : BaseEntity<Int64>
    {
        public virtual int UserID { get; set; }
        public virtual String Street { get; set; }
        public virtual String City { get; set; }
        public virtual String Country { get; set; }

        public virtual ProfileUser ProfileUser { get; set; }

        public override bool Equals(object address)
        {
            if (address == null)
                return false;
            var t = address as Address;
            if (t == null)
                return false;
            if (UserID == t.UserID && Street == t.Street && t.City==t.City && t.Country==t.Country)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|"+ UserID + "|" +Street + "|" + City + "|" + Country ).GetHashCode();
        }  

    }
}
