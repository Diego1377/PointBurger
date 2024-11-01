using IOc;

namespace PointBurguer.Windows
{
    internal static class Program
    {
        private static IServiceProvider serviceProvider;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            serviceProvider = DI.ConfigurarServicios();
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal(serviceProvider));
        }
    }
}