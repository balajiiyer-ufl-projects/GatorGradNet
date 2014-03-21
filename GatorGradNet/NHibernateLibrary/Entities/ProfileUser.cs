using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class ProfileUser
    {
        public virtual int UserID { get; set; }
        public virtual String Username { get; set; }
        public virtual String Password { get; set; }
        public virtual String Email { get; set; }
        public virtual String PrevEducation { get; set; }
        public virtual String PrevWork { get; set; }
        public virtual String PrevLocation { get; set; }
        public virtual String CurrentWork { get; set; }
    }
}
