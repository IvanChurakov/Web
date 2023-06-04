using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
