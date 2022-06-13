using BookApp.Domain;

namespace BookApp.Database
{
    public class BookDatabase : IBookDatabase
    {
        private int counter = 0;
        private List<Book> books;

        public BookDatabase()
        {
            books = new List<Book>();

            Insert(new Book
            {
                Author = "Ken Field",
                Description = "Tof boek",
                PublishDate = new DateTime(2021, 05, 19),
                Rating = 10,
                Title = "C# Yay"
            });

            Insert(new Book
            {
                Author = "Ken Field",
                Description = "Tof boek",
                PublishDate = new DateTime(2022, 02, 14),
                Rating = 9,
                Title = "C# 2 Yay"
            });

            Insert(new Book
            {
                Author = "Emre Avci",
                Description = "Minder tof boek",
                PublishDate = new DateTime(2022, 05, 14),
                Rating = 7,
                Title = "C# maar beter"
            });
        }

        public void Delete(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                books.Remove(book);
            }
        }

        public Book Get(int id)
        {
            return books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public Book Insert(Book book)
        {
            book.Id = ++counter;
            books.Add(book);
            return book;
        }

        public void Update(int id, Book updatedBook)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            if (book != null)
            {
                book.Author = updatedBook.Author;
                book.Description = updatedBook.Description;
                book.PublishDate = updatedBook.PublishDate;
                book.Rating = updatedBook.Rating;
            }
        }
    }
}
