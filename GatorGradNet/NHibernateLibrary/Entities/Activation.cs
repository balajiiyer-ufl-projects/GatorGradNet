using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    class Activation
    {
        #region Public Members
        //public virtual Int64 UserID { get; set; }
        public virtual Int64 Code { get; set; }
        public virtual ProfileUser UserId { get; set; }

        public override bool Equals(object activationObj)
        {
            if (activationObj == null)
                return false;
            var instance = activationObj as Activation;
            if (instance == null)
                return false;
            if (Code == instance.Code && UserId == instance.UserId)
                return true;
            return false;
        }
        public override int GetHashCode()
        {
            return (GetType().FullName + "|" + UserId +
               "|" + Code ).GetHashCode();
        }

        #endregion 
    }
}
