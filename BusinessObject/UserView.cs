﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class UserView
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string LoginID { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> PasswordModifiedOn { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> UserType { get; set; }
        public Nullable<bool> AllowAdd { get; set; }
        public Nullable<bool> AllowUpdate { get; set; }
        public Nullable<bool> AllowReverse { get; set; }
        public Nullable<bool> AllowAuthorize { get; set; }
        public Nullable<bool> AllowDelete { get; set; }
        public Nullable<bool> AmountLimit { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    }
}