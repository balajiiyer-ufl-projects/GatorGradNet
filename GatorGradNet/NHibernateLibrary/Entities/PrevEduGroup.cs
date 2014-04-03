using NHibernateLibrary.Entities;
using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class PrevEduGroup : BaseEntity<Int64>
    {
        //public virtual int UserID { get; set; }
        public virtual String PreviousEducation { get; set; }

        public virtual ProfileUser UserId { get; set; }

        public override bool Equals(object prevEduGrp)
        {
            if (prevEduGrp == null)
                return false;
            var instance = prevEduGrp as PrevEduGroup;
            if (instance == null)
                return false;
            if (PreviousEducation == instance.PreviousEducation && UserId==instance.UserId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + UserId + "|" + PreviousEducation).GetHashCode();
        }  
    }
}
