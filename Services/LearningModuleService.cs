using Microsoft.EntityFrameworkCore;
using WF_job.Database;
using WF_job.Interfaces;

namespace WF_job.Services
{
    public class LearningModuleService : ILearningModuleService
    {
        private readonly AppDatabaseContext _context;
        private readonly bool _ownsContext;

        public LearningModuleService(AppDatabaseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _ownsContext = false;
        }

        public async Task<List<LearningModule>> FindAllAsync()
        {
            return await _context.LearningModules.ToListAsync();
        }
        public async Task<LearningModule> FindOneAsync(int id)
        {
            return await _context.LearningModules
                .Include(m => m.Students)
                    .ThenInclude(s => s.Grades.Where(g => g.LearningModuleId == id))
                .FirstOrDefaultAsync(m => m.Id == id);
        }
        public async Task<LearningModule> CreateOneAsync(LearningModule learningModule)
        {
            _context.LearningModules.Add(learningModule);
            await _context.SaveChangesAsync();
            return learningModule;
        }

        public async Task<LearningModule> UpdateOneAsync(LearningModule learningModule)
        {
            var existingLearningModule = await _context.LearningModules.FindAsync(learningModule.Id);

            if (existingLearningModule == null)
                throw new KeyNotFoundException($"LearningModule with ID {learningModule.Id} not found");

            existingLearningModule.Name = learningModule.Name;
            existingLearningModule.Students = learningModule.Students;
            await _context.SaveChangesAsync();

            return existingLearningModule;
        }

        public async Task<bool> DeleteOneAsync(int id)
        {
            var learningModule = await _context.LearningModules.FindAsync(id);

            if (learningModule == null)
                return false;

            _context.LearningModules.Remove(learningModule);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}