using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class Orders
    {
        public int id { get; set; }
        public DateTime OrderData { get; set; }
        public int Quantity { get; set; }

        public virtual Adress DeliveryAdress { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<RealProduct> RealProducts { get; set; }
    }
}
