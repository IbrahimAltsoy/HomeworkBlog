using Microsoft.AspNetCore.Mvc;

namespace HomeworkBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AjaxCrudController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
