using HomeworkBlog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Drawing2D;

namespace HomeworkBlog.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize]
    public class UsersController : Controller
    {
        DatabaseContext _context= new DatabaseContext();

        
        // GET: UserController
        public ActionResult Index()
        {
            var user = _context.Users.ToList();
            return View(user);
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            catch 
            {

                ModelState.AddModelError("", "Hata oluştu");
               
            }
            return View(user);
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            var user = _context.Users.Find(id);
            return View(user);
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, User user)
        {
            try
            {
                var _user = _context.Users.Update(user);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "Hata oluştu");
                
            }
            return View(user);
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            var user = _context.Users.Find(id);
            return View(user);
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, User user)
        {
            try
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
               
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
