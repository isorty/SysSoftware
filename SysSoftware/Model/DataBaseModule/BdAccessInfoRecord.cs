using Model.FileModule;

namespace Model.DataBaseModule
{
    class BdAccessInfoRecord : AccessInfoRecord
    {
        public int Id { get; set; }

        public BdAccessInfoRecord() { }

        public BdAccessInfoRecord(string login, string password, string email) : base(login, password, email) { }
      
    }
}
