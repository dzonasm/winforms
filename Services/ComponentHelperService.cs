namespace WF_job.Services
{
    public class ComponentHelperService
    {
        private SortOrder currentSortOrder = SortOrder.None;
        private int currentSortColumn = -1;

        public void SetListBoxStudents(ListBox listBox, List<Student> selectionList)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.SetSelected(i, false);
            }

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                var listBoxStudent = listBox.Items[i] as Student;
                if (listBoxStudent != null)
                {
                    bool shouldBeSelected = selectionList.Any(moduleStudent =>
                        moduleStudent.Id == listBoxStudent.Id);

                    listBox.SetSelected(i, shouldBeSelected);
                }
            }
        }

        public void SetListBoxLearningModules(ListBox listBox, List<LearningModule> selectionList)
        {
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                listBox.SetSelected(i, false);
            }

            for (int i = 0; i < listBox.Items.Count; i++)
            {
                var listBoxLearningModule = listBox.Items[i] as LearningModule;
                if (listBoxLearningModule != null)
                {
                    bool shouldBeSelected = selectionList.Any(moduleStudent =>
                        moduleStudent.Id == listBoxLearningModule.Id);

                    listBox.SetSelected(i, shouldBeSelected);
                }
            }
        }
        public void StudentListSort(object sender, DataGridViewCellMouseEventArgs e, DataGridView dataGridViewStudentList)
        {
            if (currentSortColumn == e.ColumnIndex)
            {
                currentSortOrder = currentSortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            }
            else
            {
                currentSortOrder = SortOrder.Ascending;
                currentSortColumn = e.ColumnIndex;
            }

            SortDataGridView(e.ColumnIndex, currentSortOrder, dataGridViewStudentList);
        }

        public void SortDataGridView(int columnIndex, SortOrder sortOrder, DataGridView dataGridViewStudentList)
        {
            string propertyName = dataGridViewStudentList.Columns[columnIndex].DataPropertyName;
            List<Student> studentsToSort = new List<Student>((IEnumerable<Student>)dataGridViewStudentList.DataSource);

            if (sortOrder == SortOrder.Ascending)
            {
                if (propertyName == "Name")
                    studentsToSort = studentsToSort.OrderBy(s => s.Name).ToList();
                else if (propertyName == "Surname")
                    studentsToSort = studentsToSort.OrderBy(s => s.Surname).ToList();
            }
            else
            {
                if (propertyName == "Name")
                    studentsToSort = studentsToSort.OrderByDescending(s => s.Name).ToList();
                else if (propertyName == "Surname")
                    studentsToSort = studentsToSort.OrderByDescending(s => s.Surname).ToList();
            }

            dataGridViewStudentList.DataSource = null;
            dataGridViewStudentList.DataSource = studentsToSort;

            foreach (DataGridViewColumn column in dataGridViewStudentList.Columns)
            {
                column.HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            dataGridViewStudentList.Columns[columnIndex].HeaderCell.SortGlyphDirection = sortOrder;
        }

        public void LearningModuleListSort(object sender, DataGridViewCellMouseEventArgs e, DataGridView learningModuleDataGrid)
        {
            string columnName = learningModuleDataGrid.Columns[e.ColumnIndex].Name;

            if (columnName != "nameDataGridViewTextBoxColumn1" && columnName != "surnameDataGridViewTextBoxColumn1" && columnName != "GPA")
                return;

            bool ascending = learningModuleDataGrid.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection != SortOrder.Ascending;

            SortLearningModuleDataGridView(columnName, ascending, learningModuleDataGrid);
        }

        public void SortLearningModuleDataGridView(string columnName, bool ascending, DataGridView learningModuleDataGrid)
        {
            if (!(learningModuleDataGrid.DataSource is List<StudentGradeViewModel> dataSource))
                return;

            List<StudentGradeViewModel> sortedData;

            switch (columnName)
            {
                case "nameDataGridViewTextBoxColumn1":
                    sortedData = ascending
                        ? dataSource.OrderBy(s => s.Name).ToList()
                        : dataSource.OrderByDescending(s => s.Name).ToList();
                    break;

                case "surnameDataGridViewTextBoxColumn1":
                    sortedData = ascending
                        ? dataSource.OrderBy(s => s.Surname).ToList()
                        : dataSource.OrderByDescending(s => s.Surname).ToList();
                    break;

                case "GPA":
                    sortedData = ascending
                        ? dataSource.OrderBy(s => s.GPA).ToList()
                        : dataSource.OrderByDescending(s => s.GPA).ToList();
                    break;

                default:
                    return;
            }

            learningModuleDataGrid.DataSource = sortedData;
            foreach (DataGridViewColumn column in learningModuleDataGrid.Columns)
            {
                column.HeaderCell.SortGlyphDirection = SortOrder.None;
            }

            learningModuleDataGrid.Columns[columnName].HeaderCell.SortGlyphDirection =
                ascending ? SortOrder.Ascending : SortOrder.Descending;
        }
    }

}
