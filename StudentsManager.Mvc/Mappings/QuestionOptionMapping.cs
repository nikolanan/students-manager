using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Views;

namespace StudentsManager.Mvc.Mappings
{
    public static class QuestionOptionMapping
    {
        public static QuestionOptionView ToView(this QuestionOption entity)
        {
            return new QuestionOptionView
            {
                Id = entity.Id,
                Description = entity.Description,
                IsTextOnly = entity.IsTextOnly,
                QuestionNumber = entity.Id,
                ResultValue = entity.Description,
                Base64Image = entity.ImageAddress
            };
        }
    }
}