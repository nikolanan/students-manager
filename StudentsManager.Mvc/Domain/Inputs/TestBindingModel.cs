using Newtonsoft.Json;

namespace StudentsManager.Mvc.Domain.Inputs
{
    public class TestBindingModel
    {
        [JsonProperty("testStats")] public TestStats TestStats { get; set; }

        [JsonProperty("testAnswers")] public TestAnswers TestAnswers { get; set; }
    }
}