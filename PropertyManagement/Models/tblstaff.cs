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
    
    public partial class tblstaff
    {
        public int idstaff { get; set; }
        public string staffname { get; set; }
        public string staffmobile { get; set; }
        public string staffemail { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifyedDate { get; set; }
        public string ModifyedBy { get; set; }
    }
}
