//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace style.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int BillID { get; set; }
        public string ItemsSold { get; set; }
        public Nullable<System.DateTime> Datatime { get; set; }
        public Nullable<double> Count { get; set; }
        public Nullable<int> UserID { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}
