using Microsoft.AspNetCore.Mvc;

namespace Magistri.Controllers
{
    public class SubjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
