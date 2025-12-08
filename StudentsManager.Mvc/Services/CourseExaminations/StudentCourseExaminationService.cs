using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.CourseExaminations
{
    public class StudentCourseExaminationService : IStudentCourseExaminationService
    {
        private readonly ManagerDbContext _dbContext;

        public StudentCourseExaminationService(ManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<StudentCourseExamination> GetOrCreateAsync(Guid userId, string examinationType)
        {
            var result = await _dbContext
                .StudentCourseExaminations
                .Include(examination => examination.CourseExamination)
                .FirstOrDefaultAsync(examination =>
                    examination.UserId == userId && examination.CourseExamination.Type == examinationType);

            if (result == null) return await AssignedAsync(userId, examinationType);

            return result;
        }

        public async Task<StudentCourseExamination> SetScoreAsync(Guid userId, string examinationType, int score)
        {
            var studentExamination = await GetOrCreateAsync(userId, examinationType);
            studentExamination.Score = score;

            _dbContext.StudentCourseExaminations.Update(studentExamination);
            await _dbContext.SaveChangesAsync();

            return studentExamination;
        }

        public async Task<StudentCourseExamination> AssignedAsync(Guid userId, string examinationType)
        {
            var examinations = await _dbContext
                .CourseExaminations
                .Where(examination => examination.Type == examinationType)
                .ToListAsync();

            var random = new Random();
            var position = random.Next(0, examinations.Count);

            var entity = new StudentCourseExamination
            {
                UserId = userId,
                CourseExaminationId = examinations[position].Id
            };

            await _dbContext.StudentCourseExaminations.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}