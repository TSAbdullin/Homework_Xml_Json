using Homework_Xml_Json.IoC;
using Homework_Xml_Json.Services.Interfaces;

namespace Homework_Xml_Json
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = WindsorConfig.Configure();

            var betService = container.Resolve<IBetService>();
            var playerService = container.Resolve<IPlayerService>();
            var gameService = container.Resolve<IGameService>();
            var fileServiceFactory = container.Resolve<IFileServiceFactory>();
            var analyticsService = container.Resolve<IAnalyticsService>();

            ApplicationConfiguration.Initialize();
            Application.Run(new FormMain(fileServiceFactory, betService, playerService, gameService, analyticsService));
        }
    }
}