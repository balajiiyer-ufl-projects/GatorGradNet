using NHibernateLibrary.Entities;
using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class PrevWorkGroup : BaseEntity<Int64>
    {
        //public virtual int UserID { get; set; }
        public virtual String PreviousWork { get; set; }

        public virtual ProfileUser UserId { get; set; }

        public override bool Equals(object prevWorkGrp)
        {
            if (prevWorkGrp == null)
                return false;
            var instance = prevWorkGrp as PrevWorkGroup;
            if (instance == null)
                return false;
            if (PreviousWork == instance.PreviousWork && UserId==instance.UserId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + UserId + "|" + PreviousWork).GetHashCode();
        }  
    }
}
