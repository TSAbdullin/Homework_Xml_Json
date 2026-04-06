using Homework_Xml_Json.DTO;
using System;

namespace Homework_Xml_Json.Services.Interfaces
{
    public interface IFileService
    {
        public Task<DataDto> Load(string path);
    }
}
