using Microsoft.AspNetCore.Mvc;
using StudentsManager.Mvc.Services.AppSettings;

namespace StudentsManager.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly IScreenSettingService _settingService;

        public SettingsController(IScreenSettingService settingService)
        {
            _settingService = settingService;
        }

        [HttpGet("enable/reg")]
        public async Task<IActionResult> EnableRegistrationScreen()
        {
            await _settingService.UpdateRegistrationScreenSettingAsync(true);
            return Ok();
        }

        [HttpGet("disable/reg")]
        public async Task<IActionResult> DisableRegistrationScreen()
        {
            await _settingService.UpdateRegistrationScreenSettingAsync(false);
            return Ok();
        }
    }
}