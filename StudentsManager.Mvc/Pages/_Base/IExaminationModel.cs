using Microsoft.AspNetCore.Mvc;
using StudentsManager.Mvc.Domain.Entities;

namespace StudentsManager.Mvc.Pages._Base
{
    public interface IExaminationModel
    {
        bool Enabled { get; }
        Guid StudentCourseExaminationId { get; }
        string ExaminationResourceUrl { get; }
        string? ExaminationExtraResourceUrl { get; }
        List<StudentCourseExaminationUpload> Uploads { get; }
        bool FilesLimitReached { get; }

        [BindProperty] Guid StudentExaminationId { get; set; }

        [BindProperty] IFormFile? File { get; set; }
    }
}