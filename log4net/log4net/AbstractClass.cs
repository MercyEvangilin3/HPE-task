using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace log4net
{
    public abstract class Shape
    {
        public abstract int Area();


    }
    public class Rectangle : Shape
    {
          public override int Area()
        {
            Console.WriteLine("Enter Length of Rectangle:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth of Rectangle:");
            int breadth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            int Area = length * breadth;

            return Area;
        }
    }

    public class Triangle : Shape
    {

        public override int Area()
        {
            Console.WriteLine("Enter Base of Triangle:");
            int Base = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height of Triangle:");
            int height = Convert.ToInt32(Console.ReadLine());
            int area = (Base * height) / 2;
            return area;
        }



    }

}
