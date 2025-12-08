using System.ComponentModel.DataAnnotations;

namespace StudentsManager.Mvc.Domain.Entities
{
    public class UserTopicResult
    {
        public int Id { get; set; }

        [Range(0, 10)] 
        public int Score { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public Guid TopicId { get; set; }
        public Topic? Topic { get; set; }
    }
}