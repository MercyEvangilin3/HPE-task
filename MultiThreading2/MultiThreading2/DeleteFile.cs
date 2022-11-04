using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace MultiThreading2
{
    class DeleteFile
    {
        public void textDelete()
        {
            int count = 0;
            Thread.Sleep(2000);
            string textFile = @"C:\HPE-Files\MultiThreading\Text";
            string[] files = Directory.GetFiles(textFile);
            foreach(string text in files)
            {
                if (text.Length > 5000)
                {


                    File.Delete(text);
                    count = count + 1;
                }
                Console.WriteLine("The Text File from Text folder is deleted");
            }
        }

        public void imageDelete()
        {
            int count = 0;
            Thread.Sleep(3000);
            string imageFile = @"C:\HPE-Files\MultiThreading\Images";
            string[] allfiles = Directory.GetFiles(imageFile);
            foreach(string image in allfiles)
            {
                if (image.Length > 100000)
                {

                    File.Delete(image);
                    count = count + 1;
                    
                }
                Console.WriteLine("The Image File from Image Folder is deleted ");
            }
        }

        public void videoDelete()
        {
            int count = 0;
            Thread.Sleep(4000);
            string videoFile = @"C:\HPE-Files\MultiThreading\VIdeo";
            string[] files = Directory.GetFiles(videoFile);
            foreach(string video in files)
            {
                if (video.Length > 1000000)
                {


                    File.Delete(video);
                    count = count + 1;
                }
                Console.WriteLine("The video File from Video Folder is deleted");
            }
        }
    }
}
