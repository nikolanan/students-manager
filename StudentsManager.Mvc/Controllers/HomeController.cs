using Microsoft.AspNetCore.Mvc;
using StudentsManager.Mvc.Services.CourseExaminations;

namespace StudentsManager.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExaminationSettingsService _settingsService;

        public HomeController(IExaminationSettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public async Task<IActionResult> Index()
        {
            var examinationSettingsView = await _settingsService.GetViewAsync();
            return View(examinationSettingsView);
        }
    }
}