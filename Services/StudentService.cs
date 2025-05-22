using Microsoft.EntityFrameworkCore;
using WF_job;
using WF_job.Database;
using WF_job.Interfaces;

namespace StudentManagement
{


    public class StudentService : IStudentService
    {
        private readonly AppDatabaseContext _context;
        public StudentService(AppDatabaseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Student>> FindAllAsync()
        {
            return await _context.Students
                .Include(s => s.LearningModules)
                .ToListAsync();
        }

        public async Task<Student> FindOneAsync(int id)
        {
            return await _context.Students.FindAsync(id);
        }

        public async Task<Student> CreateOneAsync(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return student;
        }

        public async Task<Student> UpdateOneAsync(Student student)
        {
            var existingStudent = await _context.Students
                .Include(s => s.LearningModules)
                .FirstOrDefaultAsync(s => s.Id == student.Id);

            if (existingStudent == null)
                throw new KeyNotFoundException($"Student with ID {student.Id} not found");

            existingStudent.Name = student.Name;
            existingStudent.Surname = student.Surname;

            if (student.LearningModules != null)
            {
                var newModuleIds = student.LearningModules.Select(m => m.Id).ToList();

                var modulesToAssign = await _context.LearningModules
                    .Where(m => newModuleIds.Contains(m.Id))
                    .ToListAsync();

                existingStudent.LearningModules.Clear();

                foreach (var module in modulesToAssign)
                {
                    existingStudent.LearningModules.Add(module);
                }
            }

            await _context.SaveChangesAsync();

            return existingStudent;
        }

        public async Task<bool> DeleteOneAsync(int id)
        {
            var student = await _context.Students.FindAsync(id);

            if (student == null)
                return false;

            _context.Students.Remove(student);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}