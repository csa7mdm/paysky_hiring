using Domain.Data;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using paysky_web_app.Models;
using Service;
using System.Diagnostics;

namespace paysky_web_app.Controllers
{
    public class VacanciesController : Controller
    {
        private readonly ILogger<VacanciesController> _logger;
        private readonly IService<Vacancy> _vacancyService;

        public VacanciesController(ILogger<VacanciesController> logger, IService<Vacancy> vacancyService)
        {
            _logger = logger;
            _vacancyService = vacancyService;
        }


        public IActionResult Index()
        {
            var vacancies = _vacancyService.GetAll();
            return View(vacancies);
        }

        public IActionResult Details(int id)
        {
            var vacancy = _vacancyService.Get(id);
            if (vacancy == null)
            {
                return NotFound();
            }
            return View(vacancy);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vacancy vacancy)
        {
            if (ModelState.IsValid)
            {
                _vacancyService.Insert(vacancy);
                return RedirectToAction(nameof(Index));
            }
            return View(vacancy);
        }

        public IActionResult Edit(int id)
        {
            var vacancy = _vacancyService.Get(id);
            if (vacancy == null)
            {
                return NotFound();
            }
            return View(vacancy);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Vacancy vacancy)
        {
            if (id != vacancy.VacancyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _vacancyService.Update(vacancy);
                return RedirectToAction(nameof(Index));
            }
            return View(vacancy);
        }

        public IActionResult Delete(int id)
        {
            var vacancy = _vacancyService.Get(id);
            if (vacancy == null)
            {
                return NotFound();
            }
            return View(vacancy);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Vacancy vacancy)
        {
            _vacancyService.Delete(vacancy);
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

