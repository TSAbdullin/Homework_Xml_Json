using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Homework_Xml_Json.Services;
using Homework_Xml_Json.Services.Interfaces;

namespace Homework_Xml_Json.IoC
{
    public static class WindsorConfig
    {
        public static IWindsorContainer Configure()
        {
            var container = new WindsorContainer();

            container.Register(
                Component.For<IBetService>().ImplementedBy<BetService>(),
                Component.For<IPlayerService>().ImplementedBy<PlayerService>(),
                Component.For<IGameService>().ImplementedBy<GameService>(),
                Component.For<IFileServiceFactory>().ImplementedBy<FileServiceFactory>(),
                Component.For<JsonFileService>(),
                Component.For<XmlFileService>()
            );

            return container;
        }
    }
}