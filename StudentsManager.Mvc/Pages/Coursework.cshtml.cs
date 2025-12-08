using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsManager.Mvc.Services.Auth;
using StudentsManager.Mvc.Services.Courseworks;

namespace StudentsManager.Mvc.Pages
{
    [Authorize]
    public class CourseworkModel : PageModel
    {
        private readonly IPrincipalService _principalService;
        private readonly ICourseworksService _service;

        public CourseworkModel(ICourseworksService courseworksService, IPrincipalService principalService)
        {
            _service = courseworksService;
            _principalService = principalService;
        }

        public string ExistingLink { get; private set; }

        public bool HasExistingLink => !string.IsNullOrEmpty(ExistingLink);

        [BindProperty] public string CourseworkLink { get; set; }

        public async Task OnGet()
        {
            var userId = _principalService.GetUserIdByClaimsPrincipal(User);
            var result = await _service.GetByUserIdAsync(userId);
            ExistingLink = result?.Link;
        }

        public async Task<IActionResult> OnPost()
        {
            if (string.IsNullOrEmpty(CourseworkLink) || string.IsNullOrWhiteSpace(CourseworkLink))
                return RedirectToPage();

            var userId = _principalService.GetUserIdByClaimsPrincipal(User);
            await _service.SaveOrUpdateAsync(CourseworkLink, userId);
            return RedirectToPage();
        }
    }
}