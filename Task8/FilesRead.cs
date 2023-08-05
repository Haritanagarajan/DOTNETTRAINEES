using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class FilesRead
    {
        public void read()
        {
            FileInfo fileInfo = new FileInfo(@"D:\Files.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
            StreamReader streamReader = new StreamReader(fileStream);

            try
            {
                string data = streamReader.ReadToEnd();
                Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader.Close();
                fileStream.Close();
            }
        }
        static void Main(string[] args)
        {
            FilesRead filesRead = new FilesRead();
            filesRead.read();
            Console.ReadLine();
        }
    }
}
