namespace WF_job.Services
{
    public class ComponentHelperService
    {
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
    }

}
