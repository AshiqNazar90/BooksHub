using BooksHub.Models;
using BooksHub.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksHub.Controllers
{
    public class BookController : Controller
    {
        IBookService BookService;

        public BookController(IBookService BookService)
        {
            this.BookService = BookService;
        }
        // GET: BookController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(Book newBook) 
        {
            BookService.Add(newBook);

            return View();
        }

     

    }
}
