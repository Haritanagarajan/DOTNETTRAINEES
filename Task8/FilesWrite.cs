using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class FilesWrite
    {
        public  void write()
        {
            //create a file 
            FileInfo fileInfo = new FileInfo(@"D:\Files.txt");
            //file permissions
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);
            //writer class
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
                writer.WriteLine("Hello welcome to files ...");
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();

            }
        }
        static void Main(string[] args)
        {
            FilesWrite program = new FilesWrite();
            program.write();
            Console.ReadLine();
        }
    }
}
