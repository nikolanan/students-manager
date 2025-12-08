namespace StudentsManager.Mvc.Domain.Views.Home
{
    public readonly struct CourseExaminationSettingsView
    {
        public CourseExaminationSettingsView(bool firstAvailable, bool secondAvailable)
        {
            FirstAvailable = firstAvailable;
            SecondAvailable = secondAvailable;
        }

        public bool FirstAvailable { get; }
        public bool SecondAvailable { get; }
    }
}