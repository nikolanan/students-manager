namespace StudentsManager.Mvc.Domain.Inputs.Click
{
    public class SaveResultsModel
    {
        public SaveResultsModel()
        {
        }

        public SaveResultsModel(bool status)
        {
            Status = status;
            Errors = Array.Empty<string>();
        }

        public bool Status { get; set; }

        public string[] Errors { get; set; }
    }
}