using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassWithCounter c1 = new ClassWithCounter();
            ClassWithCounter c2 = new ClassWithCounter();
            ClassWithCounter c3 = new ClassWithCounter();
            ClassWithCounter c4 = c3;
            Console.WriteLine(ClassWithCounter.CheckCounter());
            Console.ReadKey();
        }
    }
}
