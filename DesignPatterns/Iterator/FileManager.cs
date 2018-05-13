using System;

namespace DesignPatterns.Iterator
{
    public class FileManager
    {
            public void SeeFiles(Directory dir)
            {
                IFileIterator iterator = dir.CreateFileIterator();
                while (iterator.HasNext())
                {
                    File file = iterator.Next();
                    Console.WriteLine(file.Name);
                }
            }
    }
}
