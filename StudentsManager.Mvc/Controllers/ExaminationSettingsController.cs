using Microsoft.AspNetCore.Mvc;
using StudentsManager.Mvc.Services.CourseExaminations;

namespace StudentsManager.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExaminationSettingsController : ControllerBase
    {
        private readonly IExaminationSettingsService _service;

        public ExaminationSettingsController(IExaminationSettingsService service)
        {
            _service = service;
        }

        [HttpGet("enable/first")]
        public async Task<IActionResult> EnableFirst()
        {
            await _service.MakeFirstAvailableAsync();
            return Ok("First test enabled!");
        }

        [HttpGet("disable/first")]
        public async Task<IActionResult> DisableFirst()
        {
            await _service.MakeFirstUnavailableAsync();
            return Ok("First test disabled!");
        }

        [HttpGet("enable/second")]
        public async Task<IActionResult> EnableSecond()
        {
            await _service.MakeSecondAvailableAsync();
            return Ok("Second tests enabled!");
        }

        [HttpGet("disable/second")]
        public async Task<IActionResult> DisableSecond()
        {
            await _service.MakeSecondUnavailableAsync();
            return Ok("Second tests disabled!");
        }
    }
}