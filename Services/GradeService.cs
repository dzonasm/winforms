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

        // Create a new grade
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

        // Update an existing grade
        public async Task<Grade> UpdateOneAsync(Grade grade)
        {
            if (grade == null)
                throw new ArgumentNullException(nameof(grade), "Grade cannot be null");

            try
            {
                var existingGrade = await _context.Grades.FindAsync(grade.Id);

                if (existingGrade == null)
                    throw new KeyNotFoundException($"Grade with ID {grade.Id} not found");

                // Update properties
                existingGrade.Scores = grade.Scores;

                await _context.SaveChangesAsync();

                return existingGrade;
            }
            catch (Exception ex) when (!(ex is KeyNotFoundException))
            {
                throw new Exception($"Error updating grade: {ex.Message}", ex);
            }
        }

        // Delete a grade by ID
        public async Task<bool> DeleteOneAsync(int id)
        {
            try
            {
                var grade = await _context.Grades.FindAsync(id);

                if (grade == null)
                    throw new KeyNotFoundException($"Grade with ID {id} not found");

                _context.Grades.Remove(grade);
                await _context.SaveChangesAsync();

                return true;
            }
            catch (Exception ex) when (!(ex is KeyNotFoundException))
            {
                throw new Exception($"Error deleting grade: {ex.Message}", ex);
            }
        }

        // Find a grade by ID
        public async Task<Grade> FindOneAsync(int id)
        {
            try
            {
                var grade = await _context.Grades
                    .FirstOrDefaultAsync(g => g.Id == id);

                if (grade == null)
                    throw new KeyNotFoundException($"Grade with ID {id} not found");

                return grade;
            }
            catch (Exception ex) when (!(ex is KeyNotFoundException))
            {
                throw new Exception($"Error finding grade: {ex.Message}", ex);
            }
        }

        // Find all grades
        public async Task<List<Grade>> FindAllAsync()
        {
            try
            {
                return await _context.Grades
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving grades: {ex.Message}", ex);
            }
        }

        // Find or create a grade
        public async Task<Grade> FindOrCreateAsync(int studentId, int learningModuleId)
        {
            try
            {
                var grade = await _context.Grades
                    .FirstOrDefaultAsync(g => g.StudentId == studentId && g.LearningModuleId == learningModuleId);

                if (grade == null)
                {
                    grade = new Grade
                    {
                        StudentId = studentId,
                        LearningModuleId = learningModuleId,
                        Scores = new List<int>()
                    };

                    _context.Grades.Add(grade);
                    await _context.SaveChangesAsync();
                }

                return grade;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error finding or creating grade: {ex.Message}", ex);
            }
        }
    }
}