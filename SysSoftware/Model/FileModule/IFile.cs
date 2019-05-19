using System.Collections.Generic;

namespace Model.FileModule
{
    public interface IFile
    {
        void Write(string filePath, List<IRecord> objectToWrite);
        List<IRecord> Read(string filePath);
    }
}
