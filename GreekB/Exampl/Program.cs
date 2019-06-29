using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex219
{

    interface IInterface1
    {
        void M();
    }


    interface IInterface2
    {
        void M();
    }

    class MyClass : IInterface1, IInterface2
    {
        public void M()
        {
            Console.WriteLine("MyClass.M()");
        }
        void IInterface1.M()
        {
            Console.WriteLine("IInterface1.M()");
        }

        void IInterface2.M()
        {
            Console.WriteLine("IInterface2.M()");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.M();

            IInterface1 i1 = my;
            i1.M();

            IInterface2 i2 = my;
            i2.M();

        }
    }
}
