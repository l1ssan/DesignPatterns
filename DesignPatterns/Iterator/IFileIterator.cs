
namespace DesignPatterns.Iterator
{
   public interface IFileIterator
   {
       bool HasNext();
       File Next();
   }

    public interface IFileNumerable
    {
        IFileIterator CreateFileIterator();
        int Count { get; }
        File this[int index] { get; }
    }
}
