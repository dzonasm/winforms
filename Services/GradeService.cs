using Microsoft.EntityFrameworkCore;
using WF_job.Database;

namespace WF_job.Services
{
    public class GradeService
    {
        private readonly AppDatabaseContext _context;
        public GradeService(AppDatabaseContext context)
        {
            _context = context;
        }

        public async Task<Grade> CreateOneAsync(Grade grade)
        {
            if (grade == null)
                throw new ArgumentNullException(nameof(grade), "Grade cannot be null");

            try
            {
                _context.Grades.Add(grade);
                await _context.SaveChangesAsync();
                return grade;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating grade: {ex.Message}", ex);
            }
        }

        public async Task<Grade> UpdateOneAsync(Grade grade)
        {
            if (grade == null)
                throw new ArgumentNullException(nameof(grade), "Grade cannot be null");

            try
            {
                var existingGrade = await _context.Grades.FindAsync(grade.Id);

                if (existingGrade == null)
                    throw new KeyNotFoundException($"Grade with ID {grade.Id} not found");
                existingGrade.Scores = grade.Scores;

                await _context.SaveChangesAsync();

                return existingGrade;
            }
            catch (Exception ex) when (!(ex is KeyNotFoundException))
            {
                throw new Exception($"Error updating grade: {ex.Message}", ex);
            }
        }
    }
}