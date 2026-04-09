using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Homework_Xml_Json.Services;
using Homework_Xml_Json.Services.Interfaces;

namespace Homework_Xml_Json.IoC
{
    /// <summary>
    /// Конфигурация для Castle Windsor
    /// </summary>
    public static class WindsorConfig
    {
        /// <summary>
        /// Создает и настраивает контейнер зависимостей
        /// </summary>
        /// <returns></returns>
        public static IWindsorContainer Configure()
        {
            var container = new WindsorContainer();

            container.Register(
                Component.For<IBetService>().ImplementedBy<BetService>(),
                Component.For<IPlayerService>().ImplementedBy<PlayerService>(),
                Component.For<IGameService>().ImplementedBy<GameService>(),
                Component.For<IFileServiceFactory>().ImplementedBy<FileServiceFactory>(),
                Component.For<IAnalyticsService>().ImplementedBy<AnalyticsService>(),
                Component.For<JsonFileService>(),
                Component.For<XmlFileService>()
            );

            return container;
        }
    }
}