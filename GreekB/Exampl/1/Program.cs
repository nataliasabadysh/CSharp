using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex216
{
    class Program
    {
        static void Main(string[] args)
        {

            B c = new B(1,2,3,3,4,5,6);

            c.Reset();
            
            while (c.MoveNext())
            {
                Console.WriteLine(c.Current);
            }
        }
    }
}
