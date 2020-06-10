using System;
using System.IO;

namespace csharptutorial.PathsFilesDirectories
{
    public class DirectoryDirectoryInfo
    {
        public DirectoryDirectoryInfo()
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            var files = Directory.GetFiles(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);

            foreach (var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            // Google search Fileinfo class C#

        }
    }
}
