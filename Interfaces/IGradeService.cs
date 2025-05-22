namespace WF_job.Interfaces
{
    public interface IGradeService
    {
        Task<Grade> CreateOneAsync(Grade grade);
        Task<Grade> UpdateOneAsync(Grade grade);
    }
}