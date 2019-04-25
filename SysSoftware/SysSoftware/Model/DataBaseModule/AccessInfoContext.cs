using System.Data.Entity;

namespace SysSoftware.Model.DataBaseModule
{
    class AccessInfoContext : DbContext
    {
        public DbSet<AccessInfoRecord> AccessInfoRecords { get; set; }

        public AccessInfoContext() : base("DbConnection") { }
    }
}
