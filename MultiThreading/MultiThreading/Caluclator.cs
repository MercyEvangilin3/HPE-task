using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;
namespace MultiThreading
{
    public class Caluclator
    {

        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        int num1, num2;
        public Caluclator(int a,int b)
        {
            num1 = a;
            num2 = b;
            
        }
       public void Addition()
        {
            Thread.Sleep(2000);
            int result = num1 + num2;
            Console.WriteLine("Addition of   a and b is:"+ result);
            
        }

        public void Subraction()
        {
            Thread.Sleep(3000);
            int result = num1 - num2;
            Console.WriteLine("Subraction of a and b is:"+result);
            //Console.ReadLine();

        }

        public void Multiplication()
        {
            Thread.Sleep(4000);
            int result = num1*num2;
            Console.WriteLine("Multiplication of a and b is:" + result);
        }

        public void Division()
        {
            Thread.Sleep(5000);
            int result = num1 / num2;
            Console.WriteLine("divison of a and b is:" + result);
        }
    }
}
