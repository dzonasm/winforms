namespace WF_job.Interfaces;

public interface ILearningModuleService
{
    Task<List<LearningModule>> FindAllAsync();
    Task<LearningModule> FindOneAsync(int id);
    Task<LearningModule> CreateOneAsync(LearningModule student);
    Task<LearningModule> UpdateOneAsync(LearningModule student);
    Task<bool> DeleteOneAsync(int id);
}