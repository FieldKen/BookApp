using BookApp.Database;
using BookApp.Domain;
using BookApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookApp.Controllers
{
    public class BookController : Controller
    {
        private IBookDatabase bookDatabase;

        public BookController(IBookDatabase bookDatabase)
        {
            this.bookDatabase = bookDatabase;
        }

        public IActionResult Index()
        {
            var vm = bookDatabase.GetAll().Select(x => new BookListViewModel
            {
                Id = x.Id, // <- Nodig voor te selecteren
                Title = x.Title,
                Author = x.Author,
                PublishDate = x.PublishDate // <- Nodig voor te groeperen
            });

            return View(vm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create([FromForm] BookCreateViewModel vm)
        {
            if (TryValidateModel(vm))
            {
                var book = new Book()
                {
                    Title = vm.Title,
                    Author = vm.Author,
                    Description = vm.Description,
                    PublishDate = vm.PublishDate,
                    Rating = vm.Rating
                };

                bookDatabase.Insert(book);
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}