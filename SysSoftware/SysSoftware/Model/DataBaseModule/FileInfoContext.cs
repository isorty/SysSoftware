using System.Data.Entity;

namespace SysSoftware.Model.DataBaseModule
{
    class FileInfoContext : DbContext
    {
        public DbSet<DbFileInfoRecord> FileInfoRecords { get; set; }

        public FileInfoContext() : base("DbConnection") { }
    }
}
