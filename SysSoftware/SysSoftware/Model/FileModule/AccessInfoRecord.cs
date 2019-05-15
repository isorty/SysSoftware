using System.Security.Cryptography;

namespace SysSoftware.Model
{
    public class AccessInfoRecord : IRecord
    {

        public string Login { get; set; }

        public string HashPassword { get; set; }

        public string Email { get; set; }

        public AccessInfoRecord() { }

        public AccessInfoRecord(string login, string password, string email)
        {
            byte[] data = MD5.Create().ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            System.Text.StringBuilder sBuilder = new System.Text.StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));
            Login = login;
            HashPassword = sBuilder.ToString();
            Email = email;
        }
    }
}
