using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class AbsProduct
    {
        public int id { get; set; }
        public string Name { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<RealProduct> RealProducts { get; set; }
    }
}
