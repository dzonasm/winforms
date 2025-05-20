using System.Text.RegularExpressions;

namespace WF_job.Services
{
    public class ValidationService
    {
        private int minLength = 2;
        private int maxLength = 50;
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