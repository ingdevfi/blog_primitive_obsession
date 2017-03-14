using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveObsession
{
    class Program
    {
        // Do not compile
        //private const price BASE_PRICE = 1000;

        private const int MAX_PRICE = 1000000;

        static void Main(string[] args)
        {
            Price nonPrimitivePrice = 99.7;
                        
            if (nonPrimitivePrice >= MAX_PRICE)
                throw new Exception("Price is greater than max price");
        }
    }
}
