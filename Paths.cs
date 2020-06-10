using System;
using System.IO;

namespace csharptutorial.PathsFilesDirectories
{
    public class Paths
    {
        public Paths()
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld.sln";

            var dotIndex = path.IndexOf('.');

            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));

            Console.WriteLine("FileName: " + Path.GetFileName(path));

            Console.WriteLine("FileName without extension: " + Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("DirectoryName: " + Path.GetDirectoryName(path));
        }
    }
}
