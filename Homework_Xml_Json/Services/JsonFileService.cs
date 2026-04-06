using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;
using System;
using System.Text.Json;

namespace Homework_Xml_Json.Services
{
    public class JsonFileService : IFileService
    {
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        public async Task<DataDto> Load(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception($"Файл не найден: {path}");
            }

            var json = await File.ReadAllTextAsync(path);

            var data = JsonSerializer.Deserialize<DataDto>(json, _options);

            if (data is null)
            {
                throw new Exception("Не удалось десериализовать JSON");
            }

            return data;
        }
    }
}