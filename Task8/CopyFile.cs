using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class CopyFile
    {
        public void Copy()
        {
            FileInfo fileInfo = new FileInfo(@"D:\CopyFile.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            string sourceFile = @"D:\Files.txt";
            string destinationFile = @"D:\CopyFile.txt";

            try
            {
                File.Copy(sourceFile, destinationFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }
        static void Main(string[] args)
        {
            CopyFile copyFile = new CopyFile();
            copyFile.Copy();
            Console.ReadLine();
        }
    }
}
