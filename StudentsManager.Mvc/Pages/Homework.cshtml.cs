using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsManager.Mvc.Domain.Views.Homeworks;
using StudentsManager.Mvc.Services.Auth;
using StudentsManager.Mvc.Services.Homeworks;

namespace StudentsManager.Mvc.Pages
{
    [Authorize]
    public class HomeworkModel : PageModel
    {
        private readonly IPrincipalService _principalService;
        private readonly IHomeworksService _service;

        public HomeworkModel(IHomeworksService service, IPrincipalService principalService)
        {
            _service = service;
            _principalService = principalService;
        }

        public IReadOnlyCollection<HomeworkView> HomeworkViews { get; private set; }

        [BindProperty]
#pragma warning disable CS0108 // 'HomeworkModel.File' hides inherited member 'PageModel.File(byte[], string)'. Use the new keyword if hiding was intended.
        public IFormFile File { get; set; }
#pragma warning restore CS0108 // 'HomeworkModel.File' hides inherited member 'PageModel.File(byte[], string)'. Use the new keyword if hiding was intended.

        [BindProperty] public string RepositoryLink { get; set; }

        [BindProperty] public Guid TopicId { get; set; }

        [BindProperty] public string TopicTag { get; set; }

        public async Task OnGetAsync()
        {
            HomeworkViews = await _service.GetByUserAsync(_principalService.GetUserIdByClaimsPrincipal(User));
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (string.IsNullOrEmpty(RepositoryLink) && File.Length.Equals(0)) return RedirectToPage();

            await _service.UploadAsync(_principalService.GetUserIdByClaimsPrincipal(User), TopicId, TopicTag, File,
                RepositoryLink);
            return RedirectToPage();
        }
    }
}