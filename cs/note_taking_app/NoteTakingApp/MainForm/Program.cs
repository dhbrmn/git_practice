namespace MainForm
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Initialize database connection
            NotemanLibrary.GlobalConfig.InitializeConnections(true);
            Application.Run(new NewNoteForm());

            //Application.Run(new MainForm());
        }
    }
}