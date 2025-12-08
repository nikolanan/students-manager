namespace StudentsManager.Mvc.Domain.Entities._Base
{
    public abstract class File
    {
        public string? FileName { get; set; }

        public DateTimeOffset CreatedAtUtc { get; set; }

        public string? Path { get; set; }

        public string? Extension { get; set; }
    }
}