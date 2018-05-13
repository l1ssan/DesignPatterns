

namespace DesignPatterns.Iterator
{
    public class FileIterator:IFileIterator
    {
        readonly IFileNumerable aggregate;
        int index;
        public FileIterator(IFileNumerable a)
        {
            aggregate = a;
        }

        public bool HasNext()
        {
            return index < aggregate.Count;
        }

        public File Next()
        {
            return aggregate[index++];
        }
    }
}
