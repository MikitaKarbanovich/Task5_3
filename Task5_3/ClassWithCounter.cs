using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    class ClassWithCounter
    {
        private static int counter = 0;
        public static int CheckCounter()
        {
            return counter;
        }
        public ClassWithCounter()
        {
            counter++;
        }
    }
}
