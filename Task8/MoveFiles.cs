using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class MoveFiles
    {
        public void Move()
        {
           //MOVE WILL REPLACE THE ENTIRE FILE 
           //COPY WILL NOT REPLACE IT JUST COPIES CONTENT AND PASTE TO ANOTHER FILE

            string sourcefile = @"D:\CopyFile.txt";
            string Destinationfile = @"D:\MoveFile.txt";

            try
            {
                File.Move(sourcefile, Destinationfile);
            }
            catch (Exception ex) 
            { 
            Console.WriteLine(ex.Message);
            }
            
        }
        static void Main(string[] args)
        {
            MoveFiles moveFiles = new MoveFiles();
            moveFiles.Move();
            Console.ReadLine();
        }
    }
}
