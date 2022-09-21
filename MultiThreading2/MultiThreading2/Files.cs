using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MultiThreading2
{
    public class Files
    {
       public void MoveFolder()
        {
            string demoPath = @"C:\HPE-Files\MultiThreading\Demo\";
            string imagePath = @"C:\HPE-Files\MultiThreading\Images\";
            string textPath = @"C:\HPE-Files\MultiThreading\Text\";
            string videoPath = @"C:\HPE-Files\MultiThreading\VIdeo\";
            DirectoryInfo demo = new DirectoryInfo(demoPath);
            FileInfo[] allfiles = demo.GetFiles();


            foreach (FileInfo dir in allfiles)
            {
                if (dir.Extension == ".txt")
                {

                    
                    File.Move(demoPath+dir,textPath+dir);
                }
                if(dir.Extension==".png")
                {


                    File.Move(demoPath + dir, imagePath + dir);

                }
                if(dir.Extension==".mp4")
                {

                    File.Move(demoPath + dir, videoPath + dir);

                }
            }
            Console.ReadLine();
        }
        
    }
}
