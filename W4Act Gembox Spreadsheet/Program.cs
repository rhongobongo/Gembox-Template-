namespace W4Act_Gembox_Spreadsheet
{
    internal static class Program
    {
        // Declare form1Instance as a public static variable accessible throughout the namespace


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

    }
}
