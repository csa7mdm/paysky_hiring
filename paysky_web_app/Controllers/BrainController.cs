using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace paysky_web_app.Controllers
{
    public class BrainController : Controller
    {
        private readonly ILogger<BrainController> _logger;
        private readonly IService<Vacancy> _vacancyService;

        public BrainController(ILogger<BrainController> logger, IService<Vacancy> vacancyService)
        {
            _logger = logger;
            _vacancyService = vacancyService;
        }

        //To show all available vacancies
        public IActionResult Index()
        {
            return View();
        }

        //create new vacancy
         public IActionResult Create()
        {
            return View();
        }

        //apply for vacancy
        public IActionResult Apply()
        {
            return View();
        }
    }
}
