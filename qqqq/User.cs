using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    public class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string HashPassword { get; set; }
        public int Age { get; set; }

        public virtual Statuses Status { get; set; }
        public virtual Statuses Gander { get; set; }

        //public ICollection<Statuses> Statuses { get; set; }
    }
}
