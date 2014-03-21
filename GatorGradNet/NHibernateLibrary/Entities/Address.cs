using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class Address
    {
        public virtual int UserID { get; set; }
        public virtual String Street { get; set; }
        public virtual String City { get; set; }
        public virtual String Country { get; set; }
    }
}
