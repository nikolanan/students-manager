using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Views;

namespace StudentsManager.Mvc.Mappings
{
    public static class UserTopicMapping
    {
        public static UserTopicResultView ToUserResult(this Topic entity, Guid userId, bool passed)
        {
            return new UserTopicResultView
            {
                TopicId = entity.Id,
                UserId = userId,
                TopicDescription = entity.Description,
                Passed = passed
            };
        }
    }
}