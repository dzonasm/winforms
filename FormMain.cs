using StudentManagement;
using System.ComponentModel;
using WF_job.Database;
using WF_job.Services;

namespace WF_job
{
    public partial class FormMain : Form
    {
        public IEnumerable<Student> students = new List<Student>();
        public IEnumerable<Student> dataGridStudents = new List<Student>();
        public IEnumerable<Student> newLearningModuleStudents = new List<Student>();
        public IEnumerable<Student> editLearningModuleStudents = new List<Student>();
        public List<LearningModule> learningModules = new List<LearningModule>();
        public List<LearningModule> editLearningModulesList = new List<LearningModule>();
        public List<LearningModule> updateStudentLearningModules = new List<LearningModule>();
        private Student _updateStudent;
        private LearningModule _updateLearningModule;
        private AppDatabaseContext _context;
        private StudentService _studentService;
        private GradeService _gradeService;
        private LearningModuleService _learningModuleService;
        private CalculationService _calculationService = new CalculationService();
        private ComponentHelperService _componentHelperService = new ComponentHelperService();
        private ValidationService _validationService = new ValidationService();
        public FormMain()
        {
            InitializeComponent();
            _context = new AppDatabaseContext();
            _studentService = new StudentService(_context);
            _gradeService = new GradeService(_context);
            _learningModuleService = new LearningModuleService(_context);
            LoadStudents();
            LoadLearningModules();
        }

        // Methods:
        private void ResetUpdateStudentForm()
        {
            updateStudentLearningModulesList.SelectedItems.Clear();
            updateStudentNameBox.Text = "";
            updateStudentSurnameBox.Text = "";
            _updateStudent = null;
        }
        private void FilterStudentList(string searchText)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchText))
                {
                    for (int index = 0; index < dataGridViewStudentList.Rows.Count; index++)
                    {
                        dataGridViewStudentList.Rows[index].Visible = true;
                    }
                    return;
                }

                var filteredStudents = new BindingList<Student>();
                searchText = searchText.ToLower();

                if (dataGridViewStudentList.Rows.Count > 0)
                {
                    for (int index = 0; index < dataGridViewStudentList.Rows.Count; index++)
                    {
                        DataGridViewRow row = dataGridViewStudentList.Rows[index];
                        string firstName = row.Cells["nameDataGridViewTextBoxColumn"].Value.ToString().ToLower();
                        string lastName = row.Cells["surnameDataGridViewTextBoxColumn"].Value.ToString().ToLower();

                        if (firstName.Contains(searchText) || lastName.Contains(searchText))
                        {
                            dataGridViewStudentList.Rows[index].Visible = true;
                        }
                        else
                        {
                            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridViewStudentList.DataSource];
                            currencyManager1.SuspendBinding();
                            dataGridViewStudentList.Rows[index].Visible = false;
                            currencyManager1.ResumeBinding();
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Filter Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                dataGridViewStudentList.DataSource = dataGridStudents;
            }
        }
        public async void LoadStudents()
        {
            try
            {
                students = await _studentService.FindAllAsync();
                dataGridStudents = await _studentService.FindAllAsync();
                newLearningModuleStudents = await _studentService.FindAllAsync();
                editLearningModuleStudents = await _studentService.FindAllAsync();
                comboBoxModuleSelect_SelectedIndexChanged(null, null);
                dataGridViewStudentList.DataSource = dataGridStudents;
                dataGridViewStudentList.ReadOnly = true;
                listBoxNewLearningModuleStudents.DataSource = newLearningModuleStudents;
                listBoxNewLearningModuleStudents.DisplayMember = "FullName";
                listBoxEditLearningModuleStudentSelect.DataSource = editLearningModuleStudents;
                listBoxEditLearningModuleStudentSelect.DisplayMember = "FullName";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void LoadLearningModules()
        {
            try
            {
                UpdateComboBoxModules();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading learningModules: {ex.Message}", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void UpdateComboBoxModules()
        {
            learningModules = await _learningModuleService.FindAllAsync();
            editLearningModulesList = await _learningModuleService.FindAllAsync();
            updateStudentLearningModules = await _learningModuleService.FindAllAsync();
            comboBoxEditLearningModuleSelect.DataSource = learningModules;
            comboBoxEditLearningModuleSelect.DisplayMember = "Name";
            comboBoxModuleSelect.DataSource = editLearningModulesList;
            comboBoxModuleSelect.DisplayMember = "Name";
            updateStudentLearningModulesList.DataSource = updateStudentLearningModules;
            updateStudentLearningModulesList.DisplayMember = "Name";
        }

        // UI Events:
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ResetUpdateStudentForm();
            try
            {
                var selectedRow = dataGridViewStudentList.SelectedRows[0].DataBoundItem as Student;
                updateStudentNameBox.Text = selectedRow!.Name;
                updateStudentSurnameBox.Text = selectedRow!.Surname;
                _updateStudent = selectedRow;
                _componentHelperService.SetListBoxLearningModules(updateStudentLearningModulesList, _updateStudent.LearningModules);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Some error occured: " + ex.Message + " - " + ex.Source);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            FilterStudentList(textBox3.Text);
        }

        private void studentList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _componentHelperService.StudentListSort(sender, e, dataGridViewStudentList);
        }

        private void btnOpenNewStudentForm_Click(object sender, EventArgs e)
        {
            using (CreateStudentForm form2 = new CreateStudentForm())
            {
                form2.ShowDialog(this);
            }
            LoadStudents();
        }

        private void learningModuleDataGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            _validationService.LearningModuleDataGridScoreDisplayValidation(sender, e, learningModuleDataGrid);
        }

        private void learningModuleDataGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            _componentHelperService.LearningModuleListSort(sender, e, learningModuleDataGrid);
        }
        private async void btnSaveGrades_Click(object sender, EventArgs e)
        {
            try
            {
                LearningModule selectedLearningModule = comboBoxModuleSelect.SelectedItem as LearningModule;
                int selectedLearningModuleId = selectedLearningModule.Id;

                if (selectedLearningModuleId <= 0)
                {
                    MessageBox.Show("Please select a learning module first.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataGridViewRow row in learningModuleDataGrid.Rows)
                {
                    if (row.IsNewRow) continue;

                    var studentGradeViewModel = row.DataBoundItem as StudentGradeViewModel;
                    if (studentGradeViewModel == null) continue;

                    List<int> scores = new List<int>();
                    string scoresText = row.Cells["ScoresDisplay"]?.Value?.ToString() ?? "";

                    if (!string.IsNullOrWhiteSpace(scoresText))
                    {
                        string[] scoreStrings = scoresText.Split(',');
                        foreach (string scoreStr in scoreStrings)
                        {
                            if (int.TryParse(scoreStr.Trim(), out int score))
                            {
                                scores.Add(score);
                            }
                        }
                    }

                    if (studentGradeViewModel.GradeId == null && scores.Count == 0)
                    {
                        continue;
                    }
                    else if (studentGradeViewModel.GradeId != null)
                    {
                        Grade grade = new Grade()
                        {
                            Id = (int)studentGradeViewModel.GradeId,
                            StudentId = studentGradeViewModel.StudentId,
                            LearningModuleId = selectedLearningModuleId,
                            Scores = scores
                        };
                        await _gradeService.UpdateOneAsync(grade);
                    }
                    else
                    {
                        Grade grade = new Grade()
                        {
                            StudentId = studentGradeViewModel.StudentId,
                            LearningModuleId = selectedLearningModuleId,
                            Scores = scores
                        };
                        await _gradeService.CreateOneAsync(grade);
                    }
                }

                MessageBox.Show("Grades saved!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                comboBoxModuleSelect_SelectedIndexChanged(null, null);
            }
        }

        private async void updateStudentButton_Click(object sender, EventArgs e)
        {
            if (
                !_validationService.IsStringInputValid(updateStudentNameBox.Text, "Student Name") ||
                !_validationService.IsStringInputValid(updateStudentSurnameBox.Text, "Student Surname"))
            {
                return;
            }

            var selectedRow = dataGridViewStudentList.SelectedRows[0].DataBoundItem as Student;
            List<LearningModule> selectedLearningModules = updateStudentLearningModulesList.SelectedItems.OfType<LearningModule>().ToList();
            Student updatedStudent = new()
            {
                LearningModules = selectedLearningModules,
                Name = updateStudentNameBox.Text,
                Surname = updateStudentSurnameBox.Text,
                Id = selectedRow.Id
            };
            await _studentService.UpdateOneAsync(updatedStudent);

            ResetUpdateStudentForm();
            LoadStudents();
        }

        private async void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (_updateStudent == null || _updateStudent?.Id == null)
            {
                MessageBox.Show("No student selected for deleting");
                return;
            }

            try
            {
                _ = await _studentService.DeleteOneAsync(_updateStudent.Id);
                ResetUpdateStudentForm();
                LoadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not delete Student. Error: " + ex.Message);
            }
        }

        private async void comboBoxModuleSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LearningModule selectedLearningModule = (LearningModule)comboBoxModuleSelect.SelectedItem;
            if (selectedLearningModule == null || selectedLearningModule?.Id == null)
            {
                return;
            }

            LearningModule learningModule = await _learningModuleService.FindOneAsync(selectedLearningModule.Id);

            List<StudentGradeViewModel> studentGradeViews = new List<StudentGradeViewModel>();
            for (int i = 0; i < learningModule.Students.Count; i++)
            {
                var currentStudent = learningModule.Students[i];
                var studentGrade = currentStudent.Grades.FirstOrDefault(g => g.LearningModuleId == selectedLearningModule.Id);
                double? gpa = _calculationService.CalculateGPA(studentGrade?.Scores, 2);

                StudentGradeViewModel student = new StudentGradeViewModel()
                {
                    Name = currentStudent.Name,
                    StudentId = currentStudent.Id,
                    ScoresDisplay = studentGrade != null ? string.Join(", ", studentGrade.Scores) : "",
                    Surname = currentStudent.Surname,
                    LearningModuleId = selectedLearningModule.Id,
                    GradeId = studentGrade?.Id,
                    GPA = gpa
                };
                studentGradeViews.Add(student);
            }

            learningModuleDataGrid.DataSource = studentGradeViews;
            learningModuleDataGrid.Refresh();
        }

        private async void btnSaveNewLearningModule_Click(object sender, EventArgs e)
        {
            if (!_validationService.IsStringInputValid(textBoxNewLearningModuleName.Text, "New Learning Module Name"))
            {
                return;
            }

            LearningModule newLearningModule = new LearningModule()
            {
                Name = textBoxNewLearningModuleName.Text,
                Students = listBoxNewLearningModuleStudents.SelectedItems.OfType<Student>().ToList()
            };

            try
            {
                _ = await _learningModuleService.CreateOneAsync(newLearningModule);
                listBoxNewLearningModuleStudents.ClearSelected();
                textBoxNewLearningModuleName.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            UpdateComboBoxModules();
        }

        private async void comboBoxEditLearningModuleSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEditLearningModuleStudentSelect.ClearSelected();
            LearningModule selectedModule = comboBoxEditLearningModuleSelect.SelectedValue as LearningModule;
            _updateLearningModule = await _learningModuleService.FindOneAsync(selectedModule.Id);
            _componentHelperService.SetListBoxStudents(listBoxEditLearningModuleStudentSelect, _updateLearningModule.Students);
        }

        private async void btnEditLearningModuleSave_Click(object sender, EventArgs e)
        {

            if (!_validationService.IsStringInputValid(_updateLearningModule.Name, "Learning Module Name"))
            {
                return;
            }

            try
            {
                LearningModule updatedLearningModule = new LearningModule()
                {
                    Id = _updateLearningModule.Id,
                    Name = _updateLearningModule.Name,
                    Students = listBoxEditLearningModuleStudentSelect.SelectedItems.OfType<Student>().ToList()
                };

                _ = await _learningModuleService.UpdateOneAsync(updatedLearningModule);

                MessageBox.Show("Module updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while creating a new Learning Module: " + ex.Message);
            }
        }

        private async void btnDeleteLearningModule_Click(object sender, EventArgs e)
        {
            try
            {
                LearningModule selectedLearningModule = (LearningModule)comboBoxEditLearningModuleSelect.SelectedValue;
                if (selectedLearningModule == null || selectedLearningModule?.Id == null)
                {
                    MessageBox.Show("No Learning Module selected for deleting");
                }
                _ = await _learningModuleService.DeleteOneAsync(selectedLearningModule.Id);
                LoadLearningModules();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error trying to delete the Learning Module: " + ex.Message);
            }
        }

        private async void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
            LoadLearningModules();
        }
    }
}
