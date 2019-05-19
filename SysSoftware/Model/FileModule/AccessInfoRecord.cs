namespace Model.FileModule
{
    public class AccessInfoRecord : IRecord
    {

        public string Login { get; set; }

        public string HashPassword { get; set; }

        public string Email { get; set; }

        public AccessInfoRecord() { }

        public AccessInfoRecord(string login, string hashPassword, string email)
        {           
            Login = login;
            HashPassword = hashPassword;
            Email = email;
        }
    }
}
