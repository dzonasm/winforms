namespace WF_job
{
    public class Grade
    {
        public int Id { get; set; }
        public List<int> Scores { get; set; } = new List<int>();
        public int StudentId { get; set; }
        public int LearningModuleId { get; set; }
    }
}
