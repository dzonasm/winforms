namespace WF_job.Services
{
    public class CalculationService
    {
        public double? CalculateGPA(List<int> scores, int decimalPlaces = 2)
        {
            if (scores == null || scores.Count == 0)
                return null;

            double average = scores.Sum() / (double)scores.Count;

            return Math.Round(average, decimalPlaces);
        }
    }
}