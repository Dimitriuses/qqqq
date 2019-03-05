using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class Country
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string CitiName { get; set; }
        public string ShortName { get; set; }

        public virtual ICollection<Adress> Adresses { get; set; }
    }
}
