using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{

    internal class AddToContent
    {
        public void Add()
        {
            FileInfo fileInfo = new FileInfo(@"D:\Files.Txt");
            FileStream fileStream = fileInfo.Open(FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            try
            {
                streamWriter.WriteLine("This message is an appended one");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamWriter.Close();
                fileStream.Close();
            }
        }

        static void Main(string[] args)
        {
            AddToContent append = new AddToContent();
            append.Add();
            Console.ReadLine();
        }
    }
}
