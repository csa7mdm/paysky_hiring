using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Service;

namespace paysky_web_app.Controllers
{
    public class BrainController : Controller
    {
        private readonly ILogger<BrainController> _logger;
        private readonly IService<Vacancy> _vacancyService;
        private readonly IService<Application> _applicationService;
        private readonly IMemoryCache _memoryCache;

        public BrainController(ILogger<BrainController> logger, IService<Vacancy> vacancyService, IService<Application> applicationService, IMemoryCache memoryCache)
        {
            _logger = logger;
            _vacancyService = vacancyService;
            _applicationService = applicationService;
            _memoryCache = memoryCache;
            _logger.LogInformation("BrainController");
        }

        [AllowAnonymous]
        //To show all available vacancies
        public IActionResult Index()
        {
            _logger.LogInformation("Index");

            try
            {
                var vacancies = _vacancyService.GetAll();
            }
            catch (Exception e)
            {
                _logger.LogError(e, e.Message, new object());
                return Redirect("Error");
            }

            

            return View();
        }

        [Authorize(Roles = "Applicant")]
        //apply for vacancy
        public IActionResult Apply(string id)
        {
            _logger.LogInformation("Apply");

            
            var vacancy = _vacancyService.Get(id);
            
            if (vacancy == null)
            {
                return NotFound();
            }
            return View(vacancy);
        }

        [HttpPost]
        [Authorize(Roles = "Applicant")]
        [ValidateAntiForgeryToken]
        public IActionResult Apply(string id, Vacancy vacancy)
        {
            _logger.LogInformation("Apply");

            var currentUser = "";//_applicationService.Get(HttpContext.User.Identity);

            var application = new Application()
            {
                VacancyId = vacancy.Id,
                ApplicantId = currentUser
            };

            if (id != vacancy.VacancyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _applicationService.Update(application);
                }
                catch (Exception e)
                {
                    _logger.LogError(e, e.Message, new object());
                    return Redirect("Error");
                }
                return RedirectToAction(nameof(Index));
            }
            return View(application);
        }

        [Authorize(Roles = "Admin,Employee")]
        //create new vacancy
        public IActionResult Create()
        {
            _logger.LogInformation("Create");
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Employee")]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Vacancy vacancy)
        {
            _logger.LogInformation("Create");
            if (ModelState.IsValid)
            {
                _vacancyService.Insert(vacancy);
                return RedirectToAction(nameof(Index));
            }
            return View(vacancy);
        }
    }
}
