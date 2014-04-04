using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{

    public class Address : BaseEntity<Int64>
    {

        #region Public Members
        //public virtual Int64 UserID { get; set; }
        public virtual String Street { get; set; }
        public virtual String City { get; set; }
        public virtual String Country { get; set; }

        public virtual ProfileUser UserId { get; set; }

        public override bool Equals(object address)
        {
            if (address == null)
                return false;
            var instance = address as Address;
            if (instance == null)
                return false;
            if (Street == instance.Street && City == instance.City && Country == instance.Country && UserId==instance.UserId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|"  + UserId +
               "|" + Street + "|" + City + "|" + Country).GetHashCode();
        }

        #endregion 
    }
}
