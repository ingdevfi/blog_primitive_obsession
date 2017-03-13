using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveObsession
{
    class Program
    {
        // Ne compile pas
        //private const Quantity = 1000;
        private const int MAX_QUANTITY = 1000000;

        static void Main(string[] args)
        {
            var qty = 1000;

            if (qty > MAX_QUANTITY)
                throw new Exception("qty is greater than max qty");
        }
    }
}
