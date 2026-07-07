using System;
using System.IO;

namespace AnotherException
{
    public class Program
    {
        public static void Main()
        {
            FileStream? file = null;
            FileInfo fileInfo = new FileInfo("./test.txt");

            try
            {
                file = fileInfo.OpenWrite();
                file.WriteByte(0xF);
            }
            finally
            {
                file?.Close();
            }
            try
            {
                file = fileInfo.OpenWrite();
                Console.WriteLine("OpenWrite() hogaya");
            }
            catch (IOException)
            {
                Console.WriteLine("OpenWrite() nhi hua");

            }
        }
    }
}