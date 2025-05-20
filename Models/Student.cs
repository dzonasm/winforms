using System.ComponentModel.DataAnnotations;

namespace WF_job
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<LearningModule> LearningModules { get; set; } = new List<LearningModule>();
        public List<Grade> Grades { get; set; } = new List<Grade>();
        public string FullName
        {
            get
            {
                return Name + ", " + Surname;
            }
        }
    }
}
