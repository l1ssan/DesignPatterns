
namespace DesignPatterns.Iterator
{
    public class Directory:IFileNumerable
    {
        private File[] files;

        public Directory()
        {
        files = new[]
            {
                new File {Name = "readme.txt"},
                new File {Name = "report.xlsx"},
                new File {Name = "show.exe"}
            };    
        }


        public IFileIterator CreateFileIterator()
        {
            return new FileIterator(this);
        }

        public int Count => files.Length;

        public File this[int index] => files[index];
    }
}
