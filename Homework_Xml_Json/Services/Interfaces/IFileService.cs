using Homework_Xml_Json.Models;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для файлового сервиса
    /// </summary>
    public interface IFileService
    {
        /// <summary>
        /// Загрузка и десереализация данных из файла
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Task<AppData> Load(string path);
    }
}