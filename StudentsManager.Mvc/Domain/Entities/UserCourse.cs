namespace StudentsManager.Mvc.Domain.Entities
{
    public class UserCourse
    {
        public int Id { get; set; }

        public Guid CourseId { get; set; }
        public Course? Course { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}