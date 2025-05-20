using StudentManagement;
using WF_job.Database;
using WF_job.Services;

namespace WF_job
{
    public partial class CreateStudentForm : Form
    {
        public IEnumerable<Student> students = new List<Student>();
        public List<LearningModule> learningModules = new List<LearningModule>();
        private AppDatabaseContext _context;
        private StudentService _studentService;
        private ValidationService _validationService;
        private LearningModuleService _learningModuleService;
        public CreateStudentForm()
        {
            InitializeComponent();
            _validationService = new ValidationService();
            _context = new AppDatabaseContext();
            _studentService = new StudentService(_context);
            _learningModuleService = new LearningModuleService(_context);
            LoadLearningModules();
        }

        private async void LoadLearningModules()
        {
            try
            {
                learningModules = await _learningModuleService.FindAllAsync();
                listBoxNewStudentModuleSelect.DataSource = learningModules;
                listBoxNewStudentModuleSelect.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading learningModules: {ex.Message}", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private async void SaveNewStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Add validation to ensure text fields are not empty
                if (!_validationService.IsStringInputValid(textBoxNewStudentName.Text, "Student Name") ||
                    !_validationService.IsStringInputValid(textBoxNewStudentSurname.Text, "Student Surname"))
                {
                    return;
                }

                List<LearningModule> newStudentLearningModules = listBoxNewStudentModuleSelect.SelectedItems.OfType<LearningModule>().ToList();
                Student newStudent = new Student()
                {
                    LearningModules = newStudentLearningModules,
                    Name = textBoxNewStudentName.Text,
                    Surname = textBoxNewStudentSurname.Text
                };

                _ = await _studentService.CreateOneAsync(newStudent);
                MessageBox.Show("Student Created: " + textBoxNewStudentSurname.Text + " " + textBoxNewStudentName.Text);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not create new Student: " + ex.Message + " - " + ex.Source);
            }
        }
    }
}
