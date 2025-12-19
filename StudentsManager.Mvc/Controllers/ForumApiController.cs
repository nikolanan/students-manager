using Microsoft.AspNetCore.Mvc;
using StudentsManager.Mvc.Domain.Inputs.Forum;
using StudentsManager.Mvc.Services.Auth;
using StudentsManager.Mvc.Services.Forum;

namespace StudentsManager.Mvc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumApiController : ControllerBase
    {
        private readonly IForumService _service;

        public ForumApiController(IForumService service)
        {
            _service = service;
        }

        // GET: api/ForumApi?pageNumber=1
        [HttpGet]
        public async Task<IActionResult> GetQuestions([FromQuery] int pageNumber = 1)
        {
            var result = await _service.GetPaginatedListAsync(pageNumber);
            return Ok(result);
        }

        // POST: api/ForumApi/question
        [HttpPost("question")]
        public async Task<IActionResult> PostQuestion([FromBody] string question)
        {
            if (string.IsNullOrEmpty(question))
                return BadRequest("Question cannot be empty");

            await _service.SaveQuestionAsync(
                question,
                "1eac9820-5e6e-4d10-6e94-08de36f40f78");

            return Ok("Question posted successfully");
        }
    }
}
