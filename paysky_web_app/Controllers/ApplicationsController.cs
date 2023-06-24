using Domain.Data;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using paysky_web_app.Models;
using Service;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using Application = Domain.Models.Application;

namespace paysky_web_app.Controllers
{
    public class ApplicationsController : Controller
    {
        private readonly ILogger<ApplicationsController> _logger;
        private readonly IService<Application> _applicationService;

        public ApplicationsController(ILogger<ApplicationsController> logger, IService<Application> applicationService)
        {
            _logger = logger;
            _applicationService = applicationService;
        }


        public IActionResult Index()
        {
            var applications = _applicationService.GetAll();
            return View(applications);
        }

        public IActionResult Details(int id)
        {
            var application = _applicationService.Get(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Application application)
        {
            if (ModelState.IsValid)
            {
                _applicationService.Insert(application);
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }

        public IActionResult Edit(int id)
        {
            var application = _applicationService.Get(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, Application application)
        {
            if (id != application.ApplicantId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _applicationService.Update(application);
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }

        public IActionResult Delete(int id)
        {
            var application = _applicationService.Get(id);
            if (application == null)
            {
                return NotFound();
            }
            return View(application);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Application application)
        {
            _applicationService.Delete(application);
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
