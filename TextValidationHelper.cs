public static class TextValidationHelper
{
	public static bool ValidateInputText(TextBox textBox, ErrorProvider errorProvider, int maxLength = 40)
	{
		string input = textBox.Text;
		bool isValid = true;
		string errorMessage = "";

		// Check if empty
		if (string.IsNullOrEmpty(input))
		{
			isValid = false;
			errorMessage = "Input cannot be empty.";
		}
		// Check length
		else if (input.Length > maxLength)
		{
			isValid = false;
			errorMessage = $"Input cannot be longer than {maxLength} characters.";
		}
		// Check if contains only letters
		else if (!input.All(c => char.IsLetter(c)))
		{
			isValid = false;
			errorMessage = "Input can only contain letters.";
		}

		// Visual feedback
		if (isValid)
		{
			textBox.BackColor = Color.White;
			errorProvider?.SetError(textBox, "");
		}
		else
		{
			textBox.BackColor = Color.LightPink;
			errorProvider?.SetError(textBox, errorMessage);
		}

		return isValid;
	}
}