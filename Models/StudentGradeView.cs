public class StudentGradeViewModel
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int LearningModuleId { get; set; }
    public int? GradeId { get; set; }
    public double? GPA { get; set; }

    // This is the property that will be displayed and edited in the DataGridView
    public string ScoresDisplay { get; set; } = "";

    // Helper method to set scores from a list
    public void SetScoresFromList(List<int> scores)
    {
        ScoresDisplay = string.Join(", ", scores);
    }
}