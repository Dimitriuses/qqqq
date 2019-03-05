using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class Adress
    {
        public int id { get; set; }
        public virtual Country Country { get; set; }
        public virtual Bilding Bild { get; set; }

        public virtual ICollection<Producer> Producers { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
