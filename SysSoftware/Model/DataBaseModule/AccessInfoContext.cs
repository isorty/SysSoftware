using System.Data.Entity;

namespace Model
{
    public class AccessInfoContext : DbContext
    {
        public DbSet<DbAccessInfoRecord> AccessInfoRecords { get; set; }

        public AccessInfoContext() : base("DbConnection") { }
    }
}
