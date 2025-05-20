using System.Text.RegularExpressions;

namespace WF_job.Services
{
    public class ValidationService
    {
        private int minLength = 2;
        private int maxLength = 50;
        private int minScore = 0;
        private int maxScore = 10;
        public bool IsStringInputValid(string input, string fieldName, bool showErrorMessage = true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                if (showErrorMessage)
                {
                    ShowValidationError($"{fieldName} cannot be empty.");
                }
                return false;
            }

            if (input.Length < minLength || input.Length > maxLength)
            {
                if (showErrorMessage)
                {
                    ShowValidationError($"{fieldName} must be between {minLength} and {maxLength} characters long.");
                }
                return false;
            }

            if (!Regex.IsMatch(input, @"^[a-zA-Z\s]+$"))
            {
                if (showErrorMessage)
                {
                    ShowValidationError($"{fieldName} must contain only letters and spaces.");
                }
                return false;
            }

            return true;
        }

        public void LearningModuleDataGridScoreDisplayValidation(object sender, DataGridViewCellValidatingEventArgs e, DataGridView learningModuleDataGrid)
        {
            if (learningModuleDataGrid.Columns[e.ColumnIndex].Name == "ScoresDisplay")
            {
                try
                {
                    string scoresText = e.FormattedValue.ToString();

                    string[] scoreStrings = scoresText.Split(',');
                    foreach (string scoreStr in scoreStrings)
                    {
                        if (!string.IsNullOrWhiteSpace(scoreStr) &&
                            (!int.TryParse(scoreStr.Trim(), out int score) || score < minScore || score > maxScore))
                        {
                            e.Cancel = true;
                            learningModuleDataGrid.Rows[e.RowIndex].ErrorText =
                                $"Scores must be valid numbers between {minScore} and {maxScore}";
                            return;
                        }
                    }

                    learningModuleDataGrid.Rows[e.RowIndex].ErrorText = string.Empty;
                }
                catch (Exception)
                {
                    e.Cancel = true;
                    learningModuleDataGrid.Rows[e.RowIndex].ErrorText =
                        "Invalid format. Please enter scores as comma-separated numbers.";
                }
            }
        }


        private void ShowValidationError(string message)
        {
            MessageBox.Show(
                message,
                "Validation Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
    }
}