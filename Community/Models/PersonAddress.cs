//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Community.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonAddress
    {
        public int PersonAddressKey { get; set; }
        public Nullable<int> PersonKey { get; set; }
        public string PersonAddressApt { get; set; }
        public string PersonAddressStreet { get; set; }
        public string PersonAddressCity { get; set; }
        public string PersonAddressState { get; set; }
        public string PersonAddressPostal { get; set; }
        public Nullable<System.DateTime> PersonAddressDateAdded { get; set; }
    
        public virtual Person Person { get; set; }
    }
}
