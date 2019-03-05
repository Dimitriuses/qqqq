using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class RealProduct
    {
        public int id { get; set; }
        public int Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime ExpiresDate { get; set; }
        public int Quantity { get; set; }

        public virtual AbsProduct AbsProduct { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
