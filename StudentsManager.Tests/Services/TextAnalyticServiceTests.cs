using System;
using System.Threading.Tasks;
using Xunit;

namespace StudentsManager.Tests.Services;

public class TextAnalyticServiceTests
{
    //[Fact]
    //public async Task ProcessUserAnswersAsync_Test()
    //{
    //    // Arrange
    //    var mockResponse = new Mock<Response>();
    //    var response = Response.FromValue(TextAnalyticsModelFactory.KeyPhraseCollection(new List<string>()), mockResponse.Object);

    //    var mockClient = new Mock<TextAnalyticsClient>();

    //    await using var dbContext = new ManagerDbContext(DbContextProvider.GetDbContextOptions());
    //    var service = new TextAnalyticService(mockClient.Object, dbContext);

    //    // Act
    //    //var result = await service.ProcessUserAnswersAsync(Initial, new StringBuilder());
    //}

    [Fact]
#pragma warning disable CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
    public async Task Maths()
#pragma warning restore CS1998 // This async method lacks 'await' operators and will run synchronously. Consider using the 'await' operator to await non-blocking API calls, or 'await Task.Run(...)' to do CPU-bound work on a background thread.
    {
        var x = 2.50;
        var check = x % 0.25 == 0;
        var y = Math.Round(x * 4, MidpointRounding.ToEven) / 4;
        var z = y;
    }
}