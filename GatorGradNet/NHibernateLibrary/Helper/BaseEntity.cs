using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Helper
{
    public class BaseEntity<TIdentifier>
                where TIdentifier : new()
    {
        /// <summary>
        /// Gets or sets the Identifier.
        /// </summary>
        public virtual TIdentifier Id { get; set; }
    }
    
}
