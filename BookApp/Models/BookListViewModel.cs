namespace BookApp.Models
{
    public class BookListViewModel
    {
        public int Id { get; set; } // <- Wordt niet getoond
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; } // <- Wordt niet getoond
    }
}
