using System.Data.Entity;

namespace Model
{
    public class FileInfoContext : DbContext
    {
        public DbSet<DbFileInfoRecord> FileInfoRecords { get; set; }

        public FileInfoContext() : base("DbConnection") { }
    }
}
