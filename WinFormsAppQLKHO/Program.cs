using WinFormsAppQLKHO.Utils;
using WinFormsAppQLKHO.View;

namespace WinFormsAppQLKHO
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataHelper.serverName = "(local)";
            DataHelper.dbName = "QLK";
            DataHelper.userDb = "tlinh";
            DataHelper.password = "linh2002";

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MDI());
        }
    }
}