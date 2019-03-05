using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qqqq
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 CTX = new Model1();
            Console.Write(CTX.Users.Count().ToString());
        }
    }
}
