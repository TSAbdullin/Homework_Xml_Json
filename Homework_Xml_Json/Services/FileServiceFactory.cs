using Homework_Xml_Json.Services.Interfaces;
using System;

namespace Homework_Xml_Json.Services
{
    /// <summary>
    /// Фабрика для создания файловых сервисов
    /// </summary>
    public class FileServiceFactory : IFileServiceFactory
    {
        private readonly JsonFileService _jsonService;
        private readonly XmlFileService _xmlService;

        public FileServiceFactory(
            JsonFileService jsonService,
            XmlFileService xmlService)
        {
            _jsonService = jsonService;
            _xmlService = xmlService;
        }

        /// <summary>
        /// Возвращает файловый сервис по расширению файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public IFileService Create(string path)
        {
            if (path.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
            {
                return _jsonService;
            }

            if (path.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
            {
                return _xmlService;
            }

            throw new Exception("Неподдерживаемый формат файла");
        }
    }
}