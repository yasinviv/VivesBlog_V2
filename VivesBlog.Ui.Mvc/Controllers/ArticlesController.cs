using Microsoft.AspNetCore.Mvc;

namespace VivesBlog.Ui.Mvc.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
