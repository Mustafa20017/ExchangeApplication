using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class BillMasterView
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

        public string GridRows { get; set; }
    }
}
