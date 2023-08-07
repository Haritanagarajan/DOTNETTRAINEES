using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    internal class FileProperties
    {
    

        public void props()
        {
           
            string file = @"D:\Files.txt";

            FileInfo fileinfo = new FileInfo(file);

            //file name
            Console.WriteLine("My File's Name: \"" + fileinfo.Name + "\"");

            //file created date
            DateTime createdTime = fileinfo.CreationTime;

            //file created date
            Console.WriteLine("Date and Time File Created: " + createdTime.ToString());

            //file extension
            Console.WriteLine("myFile Extension: " + fileinfo.Extension);

            //file length
            Console.WriteLine("myFile total Size: " + fileinfo.Length.ToString());

            //file present in that directory
            Console.WriteLine("myFile filepath: " + fileinfo.DirectoryName);

            //file full name 
            Console.WriteLine("My File's Full Name: \"" + fileinfo.FullName + "\"");

            //file last access time
            Console.WriteLine("My File's Access time: \"" + fileinfo.LastAccessTime + "\"");

        }
    }

    internal class fileprops
    {
        static void Main(string[] args)
        {
            FileProperties fileprops = new FileProperties();
            fileprops.props();
            Console.ReadLine();
        }
    }
}
