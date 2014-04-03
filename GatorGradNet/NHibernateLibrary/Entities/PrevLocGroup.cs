using NHibernateLibrary.Entities;
using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class PrevLocGroup : BaseEntity<Int64>
    {
        //public virtual int UserID { get; set; }
        public virtual String PreviousLocation { get; set; }

        public virtual ProfileUser UserId { get; set; }

        public override bool Equals(object prevLocGrp)
        {
            if (prevLocGrp == null)
                return false;
            var instance = prevLocGrp as PrevLocGroup;
            if (instance == null)
                return false;
            if (PreviousLocation == instance.PreviousLocation && UserId==instance.UserId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + UserId + "|" + PreviousLocation).GetHashCode();
        }  
    }
}
