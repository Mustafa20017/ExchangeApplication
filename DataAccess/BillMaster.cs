//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class BillMaster
    {
        public int BillMasterId { get; set; }
        public string BillNo { get; set; }
        public Nullable<System.DateTime> BillDate { get; set; }
        public Nullable<int> BillType { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> TranType { get; set; }
        public Nullable<int> TransStatus { get; set; }
        public Nullable<bool> IsPosted { get; set; }
        public Nullable<int> VoucherId { get; set; }
        public Nullable<int> LcAmount { get; set; }
        public Nullable<int> FcAmount { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> Authorizedby { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> StatusChangedOn { get; set; }
    }
}