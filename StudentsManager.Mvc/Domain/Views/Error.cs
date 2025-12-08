namespace StudentsManager.Mvc.Domain.Views
{
    public class Error
    {
        public Error(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}