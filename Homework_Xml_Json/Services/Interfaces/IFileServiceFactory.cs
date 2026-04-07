using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    /// <summary>
    /// Интерфейс для фабрики файловых сервисов
    /// </summary>
    public interface IFileServiceFactory
    {
        /// <summary>
        /// Создание файлового сервиса по расширению
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        IFileService Create(string path);
    }
}