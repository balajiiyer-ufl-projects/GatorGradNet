using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class PrevWorkGroup
    {
        public virtual int UserID { get; set; }
        public virtual String PreviousWork { get; set; }
    }
}
