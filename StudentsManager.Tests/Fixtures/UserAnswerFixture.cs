using System.Collections.Generic;
using StudentsManager.Mvc.Domain.Inputs.Click;

namespace StudentsManager.Tests.Fixtures;

internal static class UserAnswerFixture
{
    internal static readonly List<UserAnswer> Initial = new()
    {
        new UserAnswer
        {
            Question = "Some binary question?",
            Answer = "No"
        },
        new UserAnswer
        {
            Question = "What is a Cookie?",
            Answer = "Cookie is blablabla blablabla!"
        }
    };
}