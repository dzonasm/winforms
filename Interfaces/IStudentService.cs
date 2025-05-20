namespace WF_job.Interfaces;

public interface IStudentService
{
    Task<IEnumerable<Student>> FindAllAsync();
    Task<Student> FindOneAsync(int id);
    Task<Student> CreateOneAsync(Student student);
    Task<Student> UpdateOneAsync(Student student);
    Task<bool> DeleteOneAsync(int id);
}