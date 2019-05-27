namespace Model
{
    public class DbAccessInfoRecord : AccessInfoRecord
    {
        public int Id { get; set; }

        public DbAccessInfoRecord() { }

        public DbAccessInfoRecord(string login, string password, string email) : base(login, password, email) { }
      
    }
}
