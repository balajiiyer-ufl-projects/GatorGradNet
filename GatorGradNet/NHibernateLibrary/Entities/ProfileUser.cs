using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary
{
    public class ProfileUser : BaseEntity<Int64>
    {
        public virtual int UserID { get; set; }
        public virtual String Username { get; set; }
        public virtual String Password { get; set; }
        public virtual String Email { get; set; }
        public virtual String PrevEducation { get; set; }
        public virtual String PrevWork { get; set; }
        public virtual String PrevLocation { get; set; }
        public virtual String CurrentWork { get; set; }
        //public virtual Address Address { get; set; }

        public virtual Iesi.Collections.Generic.ISet<Address> Addresses { get; set; } 
    }
}
