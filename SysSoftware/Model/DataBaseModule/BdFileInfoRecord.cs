using Model.FileModule;

namespace Model.DataBaseModule
{
    class BdFileInfoRecord : FileInfoRecord
    {
        public int Id { get; set; }

        public BdFileInfoRecord() { }

        public BdFileInfoRecord(string path, double size, string creationDate) : base(path, size, creationDate) { }

    }
}
