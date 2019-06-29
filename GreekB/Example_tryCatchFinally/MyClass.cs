using System;
using System.IO;

namespace Ex215
{
    class MyClass 
    {
        public static void A()
        {
            throw new MyException("msg1", 2019);
            throw new MyException("msg1", 1234);
            throw new MyException("msg1", 123);
            throw new MyException("msg1", 12);


            throw new MemberAccessException();
            throw new DivideByZeroException();
            throw new FileNotFoundException();
            throw new IndexOutOfRangeException();
        }
    }
}
