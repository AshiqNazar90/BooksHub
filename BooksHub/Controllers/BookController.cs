using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BooksHub.Controllers
{
    public class BookController : Controller
    {
        // GET: BookController
        public ActionResult Index()
        {
            return View();
        }

       
    }
}
