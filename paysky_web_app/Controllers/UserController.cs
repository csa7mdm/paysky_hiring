using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using paysky_web_app.Models;
using Service;
using System.Diagnostics;

namespace paysky_web_app.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IService<User> _userService;

        public UserController(ILogger<UserController> logger, IService<User> userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var users = _userService.GetAll();
            return View(users);
        }

        public IActionResult Details(int id)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Insert(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public IActionResult Edit(int id)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _userService.Update(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public IActionResult Delete(int id)
        {
            var user = _userService.Get(id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, User user)
        {
            _userService.Delete(user);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}