using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class PrevLocGroup
    {
        public virtual int UserID { get; set; }
        public virtual String PreviousLocation { get; set; }
    }
}
