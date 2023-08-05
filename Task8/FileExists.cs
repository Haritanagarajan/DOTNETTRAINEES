using System;
using System.Collections.Generic;
//added for FileExists
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class FileExists
    {
        public void Checkfiles()
        {
           string filecheck = @"D:\Filecheck.txt";

          
            try
            {
                if (File.Exists(filecheck))
                {
                    Console.WriteLine("file exists so we are deleteing the file.");
                    File.Delete(filecheck);
                }
                else
                {
                    Console.WriteLine(" file does not exists so " +  "create the file and some contents");
                    FileInfo fileInfo = new FileInfo(filecheck);
                    FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite,FileShare.Read);
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    try
                    {
                        streamWriter.WriteLine("hello this content is added only when file does not exists");
                    }
                    catch(Exception ex) 
                    { 
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        streamWriter.Close();
                        fileStream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Main(string[] args)
        {
            FileExists fileExists = new FileExists();
            fileExists.Checkfiles();
            Console.ReadLine();
        }
    }
}
