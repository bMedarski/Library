using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Server.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}