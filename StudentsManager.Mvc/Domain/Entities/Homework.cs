using System.ComponentModel.DataAnnotations.Schema;
using File = StudentsManager.Mvc.Domain.Entities._Base.File;

namespace StudentsManager.Mvc.Domain.Entities
{
    public class Homework : File
    {
        public int Id { get; set; }

        public string? RepositoryLink { get; set; }

        [NotMapped] 
        public string? Link => string.IsNullOrEmpty(Path) ? RepositoryLink : Path;

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid TopicId { get; set; }
        public Topic? Topic { get; set; }
    }
}