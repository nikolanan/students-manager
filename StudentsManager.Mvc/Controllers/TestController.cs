using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentsManager.Mvc.Domain.Inputs;
using StudentsManager.Mvc.Services.Auth;
using StudentsManager.Mvc.Services.Options;
using StudentsManager.Mvc.Services.Tests;
using StudentsManager.Mvc.Services.Topics;

namespace StudentsManager.Mvc.Controllers
{
    [Authorize]
    public class TestController : Controller
    {
        private readonly IPrincipalService _principalService;
        private readonly ITestsService _testsService;
        private readonly ITopicsService _topicsService;
        private readonly IUserAnswersService _userAnswersService;
        private readonly IUserTopicResultsService _userTopicResultsService;

        public TestController(
            ITopicsService topicsService,
            ITestsService testsService,
            IPrincipalService principalService,
            IUserAnswersService userAnswersService,
            IUserTopicResultsService userTopicResultsService)
        {
            _topicsService = topicsService;
            _testsService = testsService;
            _principalService = principalService;
            _userAnswersService = userAnswersService;
            _userTopicResultsService = userTopicResultsService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _principalService.GetUserIdByClaimsPrincipal(User);
            var result = await _topicsService.GetUserTopicResultsAsync(userId);
            return View(result);
        }

        [HttpGet]
        [Route("start/{topicId}")]
        public async Task<IActionResult> Start([FromRoute] Guid topicId)
        {
            var userId = _principalService.GetUserIdByClaimsPrincipal(User);
            if (await _topicsService.HasUserTopicResultAsync(userId, topicId))
                return RedirectToAction("Result", new { topicId });
            var result = await _testsService.GetTestAsync(topicId, userId);

            TempData["topicId"] = topicId;
            return View(result);
        }

        [HttpPost]
        public async Task<IActionResult> RegisterUserAnswer([FromBody] ChosenOption optionModel)
        {
            var userId = _principalService.GetUserIdByClaimsPrincipal(User);
            await _userAnswersService.AddAsync(userId, optionModel.ChosenOptionId);
            return Ok();
        }

        [HttpPost]
        [Route("start/SubmitAnswers")]
        public async Task<IActionResult> SubmitAnswers([FromQuery] string v, [FromBody] TestBindingModel model)
        {
            var topicId = TempData["topicId"].ToString() ?? throw new ArgumentNullException();
            var userId = _principalService.GetUserIdByClaimsPrincipal(User);

            await _userTopicResultsService.ProcessAsync(Guid.Parse(topicId), userId);

            var result = new
            {
                redirect = $"{Url.Action("Done", "Test")}"
            };

            return Json(result);
        }

        [HttpGet]
        public IActionResult Done()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Result(Guid topicId)
        {
            var userId = _principalService.GetUserIdByClaimsPrincipal(User);
            var result = await _userTopicResultsService.GetSingleAsync(topicId, userId);
            return View(result);
        }
    }
}