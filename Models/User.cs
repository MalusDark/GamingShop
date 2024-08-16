using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace GamingShop.Models
{
    public class User
    {
        private long _id;
        private string _userName;
        private string _email;
        private string _password;

        public string UserName { get => _userName; set => _userName = value; }

        public string Email { get => _email; set => _email = value; }
        
        public string Password { get => _password; set => _password = value; }
        public long Id { get => _id; set => _id = value; }
    }
}
