using Homework_Xml_Json.DTO;
using Homework_Xml_Json.Models;
using Homework_Xml_Json.Services.Interfaces;
using System;
using System.Text.Json;

namespace Homework_Xml_Json.Services
{
    /// <summary>
    /// Сервис для обработки JSON файлов
    /// </summary>
    public class JsonFileService : IFileService
    {
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        /// <summary>
        /// Загрузка и десереализация JSON файла
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

            var json = await File.ReadAllTextAsync(path);

            var data = JsonSerializer.Deserialize<AppData>(json, _options);

            if (data is null)
            {
                throw new Exception("Не удалось десериализовать JSON");
            }

            return data;
        }
    }
}