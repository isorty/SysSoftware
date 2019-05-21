using System.Data.Entity;

namespace SysSoftware.Model.DataBaseModule
{
    class AccessInfoContext : DbContext
    {
        public DbSet<DbAccessInfoRecord> AccessInfoRecords { get; set; }

        public AccessInfoContext() : base("DbConnection") { }
    }
}
