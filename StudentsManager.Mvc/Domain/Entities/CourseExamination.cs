namespace StudentsManager.Mvc.Domain.Entities
{
    public class CourseExamination
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string ResourceUrl { get; set; }

        public string? ExtraResourceUrl { get; set; }

        public ICollection<StudentCourseExamination>? StudentExaminations { get; set; }
    }
}