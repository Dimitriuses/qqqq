using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class Producer
    {
        public int id { get; set; }
        public string Name { get; set; }
        public virtual Adress Adress { get; set; }

        public virtual ICollection<RealProduct> RealProducts { get; set; }
    }
}
