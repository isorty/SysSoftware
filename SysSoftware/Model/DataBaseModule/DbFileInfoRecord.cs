namespace Model
{
    public class DbFileInfoRecord : FileInfoRecord
    {
        public int Id { get; set; }

        public DbFileInfoRecord() { }

        public DbFileInfoRecord(string path, double size, string creationDate) : base(path, size, creationDate) { }

    }
}
