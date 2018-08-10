using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            // FILE provides static methods

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

            string path = @"c:\somefile.jpg";
            File.Delete(path);

            if (File.Exists(path))
            {
                // etc...
            }

            string content = File.ReadAllText(path);




            // FILEINFO provides instance methods

            FileInfo fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                // etc....
            }





            // DIRECTORY
            Directory.CreateDirectory(@"c:\temp\folder1");

            string[] files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.jpg", SearchOption.AllDirectories);
            foreach (string file in files)
                Console.WriteLine(file);

            string[] directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            foreach (string directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");




            // DIRECTORYINFO

            DirectoryInfo directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();





            // PATH

            string path = @"c:\projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";

            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));


        }
    }
}
