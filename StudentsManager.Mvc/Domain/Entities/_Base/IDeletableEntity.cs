namespace StudentsManager.Mvc.Domain.Entities._Base
{
    public interface IDeletableEntity
    {
        bool IsDeleted { get; set; }

        DateTime? DeletedOn { get; set; }
    }
}