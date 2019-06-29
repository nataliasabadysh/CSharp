using SaverLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex212
{
    class Program
    {
        static void Main(string[] args)
        {
            var o1 = new SaverFile("SaverFileName");
            var o2 = new SaverXml("SaverXmlName");
            var o3 = new SaverJson("SaverJsonName");

            Console.ReadLine();

            SaverFiles saver = new SaverFiles(o1);
            saver.SaveAs();

            Console.ReadLine();

            saver.Logic = o2;
            saver.SaveAs();

            Console.ReadLine();

            saver.SetLogic(o3, "1", "1");
            saver.SaveAs();

            Console.ReadLine();
        }
    }
}
