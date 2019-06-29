using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Ex217Dispose
{
    class Program
    {
        static void Main(string[] args)
        {

            using (MyClass mc = new MyClass())
            {

            }

            using (StreamWriter sw = new StreamWriter("a"))
            {

              
            }

            using (A a1 = new A())
            {

            }




            //Thread.Sleep(2000);

            A a = new A();

            a.Dispose();

            GC.Collect();// ~~~~!!!!

            Console.ReadLine();

        }
    }
}
