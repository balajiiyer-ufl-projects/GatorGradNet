﻿using NHibernateLibrary.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateLibrary.Entities
{
    public class CompanyIndustry : BaseEntity<Int64>
    {
        public virtual int CompanyID { get; set; }
        public virtual String Industry { get; set; }
    }
}
