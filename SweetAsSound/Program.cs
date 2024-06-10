using Microsoft.EntityFrameworkCore;

namespace SweetAsSound
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using (var context = new AppdDbContex())
            {
                context.Database.Migrate();
            }
                Application.Run(new Registration());
        }
    }
}