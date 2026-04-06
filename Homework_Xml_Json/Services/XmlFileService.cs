using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Services.Interfaces;
using System;
using System.Xml.Serialization;

namespace Homework_Xml_Json.Services
{
    public class XmlFileService : IFileService
    {
        public async Task<DataDto> Load(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception($"Файл не найден: {path}");
            }

            var xml = await File.ReadAllTextAsync(path);

            var serializer = new XmlSerializer(typeof(DataDto));

            using var reader = new StringReader(xml);
            var data = serializer.Deserialize(reader) as DataDto;

            if (data is null)
            {
                throw new Exception("Не удалось десериализовать XML");
            }

            return data;
        }
    }
}
