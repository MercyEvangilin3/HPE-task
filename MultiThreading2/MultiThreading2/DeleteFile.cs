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
            Thread.Sleep(2000);
            string textFile = @"C:\HPE-Files\MultiThreading\Text";
            string[] files = Directory.GetFiles(textFile);
            foreach(string text in files)
            {
                File.Delete(text);
                Console.WriteLine("The Text File from Text folder is deleted");
            }
        }

        public void imageDelete()
        {
            Thread.Sleep(3000);
            string imageFile = @"C:\HPE-Files\MultiThreading\Images";
            string[] allfiles = Directory.GetFiles(imageFile);
            foreach(string image in allfiles)
            {
                File.Delete(image);
                Console.WriteLine("The Image File from Image Folder is deleted ");
            }
        }

        public void videoDelete()
        {
            Thread.Sleep(4000);
            string videoFile = @"C:\HPE-Files\MultiThreading\VIdeo";
            string[] files = Directory.GetFiles(videoFile);
            foreach(string video in files)
            {
                File.Delete(video);
                Console.WriteLine("The video File from Video Folder is deleted");
            }
        }
    }
}
