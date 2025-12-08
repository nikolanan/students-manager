namespace StudentsManager.Mvc.Domain.Entities
{
    public class Course
    {
        public Guid Id { get; set; }
        
        public string Description { get; set; }

        public IEnumerable<Topic>? Topics { get; set; }
        public IEnumerable<UserCourse>? UserCourses { get; set; }
    }
}