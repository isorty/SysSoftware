using System.Collections.Generic;

namespace Model
{
    public interface IFile
    {
        void Write(string filePath, List<IRecord> objectToWrite);
        List<IRecord> Read(string filePath);
    }
}
