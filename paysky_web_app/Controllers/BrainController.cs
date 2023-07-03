using Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace paysky_web_app.Controllers
{
    public class BrainController : Controller
    {
        private readonly ILogger<BrainController> _logger;
        private readonly IService<Vacancy> _vacancyService;
        private readonly IService<Application> _applicationService;

        public BrainController(ILogger<BrainController> logger, IService<Vacancy> vacancyService, IService<Application> applicationService)
        {
            _logger = logger;
            _vacancyService = vacancyService;
            _applicationService = applicationService;

            _logger.LogInformation("BrainController");
        }

        [AllowAnonymous]
        //To show all available vacancies
        public IActionResult Index()
        {
            var vacancies = _vacancyService.GetAll();

            _logger.LogInformation("Index");

            return View();
        }

        [Authorize(Roles = "Admin,Employee")]
        //create new vacancy
        public IActionResult Create()
        {
            _logger.LogInformation("Create");
            return View();
        }

        [Authorize(Roles = "Applicant")]
        //apply for vacancy
        public IActionResult Apply()
        {
            _logger.LogInformation("Apply");
            return View();
        }
    }
}
