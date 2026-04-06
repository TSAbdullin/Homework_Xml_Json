using Homework_Xml_Json.Services.Interfaces;
using System;

namespace Homework_Xml_Json.Services
{
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
