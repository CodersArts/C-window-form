using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Format_Different_way
{
    class Program
    {
        static void Main(string[] args)
        { 
            DateTime CurrDate = DateTime.Now;

            // Format Datetime in different formats and display them  
            Console.WriteLine(CurrDate.ToString("MM/dd/yyyy"));       // 06-12-2019
            Console.WriteLine(CurrDate.ToString("dddd, dd MMMM yyyy"));  //Wednesday, 12 June 2019
            
            Console.WriteLine(CurrDate.ToString("dddd, dd MMMM yyyy")); // Wednesday, 12 June 2019
            Console.WriteLine(CurrDate.ToString("dddd, dd MMMM yyyy"));  // Wednesday, 12 June 2019 19:52:58
            Console.WriteLine(CurrDate.ToString("dddd, dd MMMM yyyy"));   // Wednesday, 12 June 2019
            Console.WriteLine(CurrDate.ToString("dddd, dd MMMM yyyy"));   // Wednesday, 12 June 2019
            Console.WriteLine(CurrDate.ToString("dddd, dd MMMM yyyy HH:mm:ss")); //Wednesday, 12 June 2019 19:37:05
            Console.WriteLine(CurrDate.ToString("MM/dd/yyyy HH:mm"));           // 06-12-2019 19:37
            Console.WriteLine(CurrDate.ToString("MM/dd/yyyy hh:mm tt"));     //   06-12-2019 07:37 PM
            Console.WriteLine(CurrDate.ToString("MM/dd/yyyy H:mm"));        // 06-12-2019 19:37
            Console.WriteLine(CurrDate.ToString("MM/dd/yyyy h:mm tt"));     // 06-12-2019 19:37
            Console.WriteLine(CurrDate.ToString("MM/dd/yyyy HH:mm:ss"));  //06-12-2019 7:37 PM
            Console.WriteLine(CurrDate.ToString("MMMM dd"));        // 06-12-2019 19:37:05
            Console.WriteLine(CurrDate.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss.fffffffK"));  //2019'-`06'-`12'T'19':'52':'58.7775830+05:30
            Console.WriteLine(CurrDate.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’"));   // Wed, 12 Jun 2019 19':'52':'58 `G6T'
            Console.WriteLine(CurrDate.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss")); // 2019'-`06'-`12'T'19':'52':'58
            Console.WriteLine(CurrDate.ToString("HH:mm"));        //  19:52
            Console.WriteLine(CurrDate.ToString("hh:mm tt"));    // 07:52 PM
            Console.WriteLine(CurrDate.ToString("H:mm"));       // 19:52
            Console.WriteLine(CurrDate.ToString("h:mm tt"));      // 7:52 PM
            Console.WriteLine(CurrDate.ToString("HH:mm:ss"));   // 19:52:58
            Console.WriteLine(CurrDate.ToString("yyyy MMMM"));   // 2019 June

            Console.ReadKey();
        }
    }
}
