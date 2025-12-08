namespace StudentsManager.Mvc.Domain.Entities
{
    public class UserCoursework
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public int Points { get; set; }
    }
}