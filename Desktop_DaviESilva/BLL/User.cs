using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Desktop_DaviESilva_F0450H6.BLL
{
    class User
    {
        private int? iduser;
        private string username;
        private string email;
        private string password;
        private string birthday;
        private string document;


        public User(string username, string email, string password, string birthday, string document)
        {
            this.IdUser = null;
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.Birthday = birthday;
            this.Document = document;

        }

        public int? IdUser { get => iduser; set => iduser = value; }
        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Document { get => document; set => document = value; }

    }
}
