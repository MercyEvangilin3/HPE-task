using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace MultiThreading2
{
    class Program
    {
        static void Main(string[] args)
        {
            Files mf = new Files();
            Thread t1 = new Thread(mf.MoveFolder);
            t1.Start();

            Console.WriteLine("Done with moving Files");
            DeleteFile df = new DeleteFile();
            Thread t2 = new Thread(df.textDelete);
            Thread t3 = new Thread(df.imageDelete);
            Thread t4 = new Thread(df.videoDelete);

            t2.Start();
            t3.Start();
            t4.Start();

            Console.WriteLine("All the Files are Deleted");
        }
    }
}
