using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Views;

namespace StudentsManager.Mvc.Mappings
{
    public static class TestQuestionMapping
    {
        public static TestQuestionView ToView(this TestQuestion entity)
        {
            return new TestQuestionView
            {
                Id = entity.Id,
                Description = entity.Description,
                Options = entity
                    .Options
                    .Select(option => option.ToView())
                    .ToList()
            };
        }
    }
}