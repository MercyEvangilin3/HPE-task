using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace log4net
{
    class Program
    {
        //progarm to claculate area of triangle
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            try
            {
                Rectangle r = new Rectangle();
                int rectangle = r.Area();
                Triangle tr = new Triangle();
                int triangle = tr.Area();
               log.Info($"Area of Rectangle is {rectangle}");
                Console.WriteLine("\n");
               log.Info($"Area of Triangle is {triangle}");
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


     }
}

;