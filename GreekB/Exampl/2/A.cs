using System;
using System.Drawing;
using System.Linq;

namespace Ex217Dispose
{

    class MyClass
    {

    }

    class A:IDisposable
    {
        int[] a;

        public A()
        {
            a = new int[111];
        }
        
        ~A()
        {
            Console.Beep(1000, 1000);
        }

        public void Dispose()
        {
            System.IO.File.WriteAllLines("data", a.Select(e => e.ToString()));

            GC.SuppressFinalize(this);
        }
    }


}
