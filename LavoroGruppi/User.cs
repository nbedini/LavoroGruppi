using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavoroGruppi
{
    class User
    {
        public string Username { get; set; }
        public string NomeCompleto { get; set; }
        public string Password { get; set; }

        public User(string username, string nomecompleto, string password)
        {
            Username = username;
            Password = password;
            NomeCompleto = nomecompleto;
        }

    }
}
