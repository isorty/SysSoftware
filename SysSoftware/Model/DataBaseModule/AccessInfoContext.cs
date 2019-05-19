﻿using System.Data.Entity;

namespace Model.DataBaseModule
{
    class AccessInfoContext : DbContext
    {
        public DbSet<BdAccessInfoRecord> AccessInfoRecords { get; set; }

        public AccessInfoContext() : base("DbConnection") { }
    }
}