using BookApp.Domain;

namespace BookApp.Database
{
    public interface IBookDatabase
    {
        Book Insert(Book book);
        IEnumerable<Book> GetAll();
        Book Get(int id);
        void Update(int id, Book book);
        void Delete(int id);
    }
}
