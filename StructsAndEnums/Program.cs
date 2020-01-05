#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            //Month first = Month.November;
            //first += 3;
            //Console.WriteLine(first);

            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);
            Date weddingAnniversary = new Date(2019, Month.November, 25);
            Console.WriteLine(weddingAnniversary);
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
