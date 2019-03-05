using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class Category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public bool IsLegal { get; set; }

        public virtual ICollection<AbsProduct> AbsProducts { get; set; }
    }
}
