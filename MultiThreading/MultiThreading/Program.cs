using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
namespace MultiThreading
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the First value:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second value:");
            int b = Convert.ToInt32(Console.ReadLine());
            

            Caluclator cs = new Caluclator(a,b);
            Thread t1 = new Thread(cs.Addition);
            Thread t2 = new Thread(cs.Subraction);
            Thread t3 = new Thread(cs.Multiplication);
            Thread t4 = new Thread(cs.Division);

            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();

            Console.ReadLine();

        }
    }
}
