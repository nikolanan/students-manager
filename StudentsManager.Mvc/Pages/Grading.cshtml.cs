using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentsManager.Mvc.Domain.Views.Statistics;
using StudentsManager.Mvc.Services.Statistics;

namespace StudentsManager.Mvc.Pages
{
    public class GradingModel : PageModel
    {
        private readonly IStudentsGradingService _service;

        public GradingModel(IStudentsGradingService service)
        {
            _service = service;
        }

        public IReadOnlyList<StudentGrade> StudentGrades { get; private set; } = new List<StudentGrade>();

        public async Task OnGetAsync()
        {
            StudentGrades = await _service.GetAsync();
        }
    }
}