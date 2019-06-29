using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Ex215
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClass.A();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка DivideByZeroException");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Ошибка FileNotFoundException");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Ошибка IndexOutOfRangeException");
            }
            // ========================
            catch (MyException e) when (e.Error == 1  )
            {
                Console.WriteLine("Ошибка MyException 1");
                Console.WriteLine(e.Message);
               
            }
            catch (MyException e) when (e.Error == 2)
            {
                Console.WriteLine("Ошибка MyException 2");
                Console.WriteLine(e.Message);
            }
            catch (MyException e) when (e.Error == 4)
            {
                Console.WriteLine("Ошибка MyException 2");
                Console.WriteLine(e.Message);
            }
            catch (MyException e) when (e.Error == 1234)
            {
                Console.WriteLine("Ошибка MyException 2");
                Console.WriteLine(e.Message);
            }
            catch (MyException e) when (e.Error == 313)
            {
                Console.WriteLine("Ошибка MyException 2");
                Console.WriteLine(e.Message);
            }
            //========  default will catch everythoing _ Exception 
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка Exception {e.GetType()} {e}");
            }
            finally   // Блок завершения
            {
                Console.WriteLine("finally");
                
            }
        }
    }
}
