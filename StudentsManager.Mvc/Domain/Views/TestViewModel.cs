namespace StudentsManager.Mvc.Domain.Views
{
    public class TestViewModel
    {
        public TestViewModel(IReadOnlyCollection<TestQuestionView> testQuestions)
        {
            ActiveQuestion = testQuestions.First();
            FollowQuestions = testQuestions.Skip(1).ToList();
        }

        public TestQuestionView ActiveQuestion { get; }

        public List<TestQuestionView> FollowQuestions { get; }
    }
}