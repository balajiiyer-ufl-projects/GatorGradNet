using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class PrevEduGroup
    {
        public virtual int UserID { get; set; }
        public virtual String PreviousEducation { get; set; }
    }
}
