using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication27
{
    
    class Program
    {
        static void Main(string[] args)
        {
            #region dzielenie
            int liczba1;
            //liczba1 = 30 / 0;
            int liczba2 = 0, liczba3 = 30;
            try
            {
                liczba1 = liczba3 / liczba2;
            }
            catch 
            {
                Console.WriteLine("wyjątek");
            }
            
            finally
            {
                Console.WriteLine("Finally");
            }
            #endregion
            Console.ReadLine();
        }
             
    }
}
