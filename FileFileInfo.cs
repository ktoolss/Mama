using System;
using System.IO;

namespace csharptutorial.PathsFiles
{
    public class FileFileInfo
    {
        public FileFileInfo()
        {
            File.Copy(@"c:\\temp\\myfile.jpg", "d:\\temp\\myfile.jpg", true); // this is for overwriting a file if it already exists

            var path = @"c:\somefile.jpg";

            File.Delete(path);
            if(File.Exists(path))
            {
                // Do something about it
            }

            File.ReadAllText();  // returns all file text. Takes string path arguement

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);

            fileInfo.CopyTo("...");

            fileInfo.Delete();

            if(fileInfo.Exists)
            {
                // Do something about it
            }

            fileInfo.OpenRead();   // Mosh not a fan of this


        }
    }
}
