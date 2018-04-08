using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyManagement.Common
{
    public abstract class BaseEntity
    {

        public string CreatedBy { get; set; }

        public string ModifyBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifyedDate { get; set; }
    }
}