using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    public interface IFileServiceFactory
    {
        IFileService Create(string path);
    }
}
