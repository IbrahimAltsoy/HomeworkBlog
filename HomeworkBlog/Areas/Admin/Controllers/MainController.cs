using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HomeworkBlog.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
