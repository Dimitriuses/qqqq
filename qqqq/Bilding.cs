using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class Bilding
    {
        public int id { get; set; }
        public int number { get; set; }
        public char leter { get; set; }

        public virtual ICollection<Adress> Adresses { get; set; }
    }
}
