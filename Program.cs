namespace WF_job
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new FormMain());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            // Add singleton DI container

        }
    }
}