using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class MenuView
    {
        public int id { get; set; }
        public string MenuName { get; set; }
        public string URL { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}
