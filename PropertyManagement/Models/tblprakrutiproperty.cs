//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PropertyManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblprakrutiproperty
    {
        public int idprakrutiproperty { get; set; }
        public string txtlocation { get; set; }
        public string txtNamingCon { get; set; }
        public string txttype { get; set; }
        public string txtfloor { get; set; }
        public Nullable<sbyte> blnstatus { get; set; }
        public Nullable<double> sngcarpetarea { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifyedDate { get; set; }
        public string ModifyedBy { get; set; }
    }
}
