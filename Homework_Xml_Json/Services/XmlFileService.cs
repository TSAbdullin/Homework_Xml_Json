using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;
using System;
using System.Xml.Serialization;

namespace Homework_Xml_Json.Services
{
    /// <summary>
    /// Сервис для обработки XML файла
    /// </summary>
    public class XmlFileService : IFileService
    {
        /// <summary>
        /// Обработка и десереализация XML файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public async Task<AppData> Load(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception($"Файл не найден: {path}");
            }

            var xml = await File.ReadAllTextAsync(path);

            var serializer = new XmlSerializer(typeof(AppData));

            using var reader = new StringReader(xml);
            var data = serializer.Deserialize(reader) as AppData;

            if (data is null)
            {
                throw new Exception("Не удалось десериализовать XML");
            }

            return data;
        }
    }
}