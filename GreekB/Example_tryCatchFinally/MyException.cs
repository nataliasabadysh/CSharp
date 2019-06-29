using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex215
{
    class MyException: Exception
    {



        public int Error { get; set; }
        public MyException(string Msg, int Error) : base(Msg)
        {
            this.Error = Error;
        }

        public override string ToString()
        {
            return $"{this.Error} {base.Message}";
        }
    }
}
