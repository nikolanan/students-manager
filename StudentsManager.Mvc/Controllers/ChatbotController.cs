using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChatbotController(ManagerDbContext managerDbContext) : ControllerBase
{
    // GET: api/chatbot/examination-answers/022a6007-f33c-47c3-b811-08de88b121f2
    [HttpGet("examination-answers/{studentId}")]
    public async Task<IActionResult> Get([FromRoute] Guid studentId)
    {
        var result = await managerDbContext.ExaminationAnswers
            .Where(answer => answer.UserId == studentId)
            .ToListAsync();

        return Ok(result);
    }

    // POST: api/chatbot/examination-answers
    [HttpPost("examination-answers")]
    public async Task<IActionResult> Post([FromBody] ChatbotExaminationInput input)
    {
        if (input.Answers.Length == 0)
            return BadRequest("Answers cannot be empty.");

        var entity = new ExaminationAnswer
        {
            Id = Guid.NewGuid(),
            UserId = input.UserId,
            CreatedOn = DateTime.UtcNow,
            Result = JsonConvert.SerializeObject(input.Answers),
            ContentType = "chatbot",
            WasSuccessfullyProcessed = true
        };

        await managerDbContext.AddAsync(entity);
        await managerDbContext.SaveChangesAsync();

        return Ok(entity);
    }
}

public record ChatbotAnswerItem(string QuestionId, string QuestionText, string Answer);

public record ChatbotExaminationInput(Guid UserId, ChatbotAnswerItem[] Answers);
