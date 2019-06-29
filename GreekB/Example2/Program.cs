using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace Ex213
{
 

    class Program
    {
        static void Main(string[] args)
        {
            #region IEnumerable 

            Department it = new Department();

            foreach (var item in it)
            {
                Console.WriteLine(item);
            }

            #endregion

        }
    }
}
