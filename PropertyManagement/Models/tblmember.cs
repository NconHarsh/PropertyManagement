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
    
    public partial class tblmember
    {
        public int member_id { get; set; }
        public string member_name { get; set; }
        public string address { get; set; }
        public System.DateTime dob { get; set; }
        public string user_id { get; set; }
        public string password { get; set; }
        public string contact { get; set; }
        public int property_id { get; set; }
        public string email_id { get; set; }
        public sbyte isActive { get; set; }
    }
}
