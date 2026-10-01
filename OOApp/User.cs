using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp
{
    /// <summary>
    /// Defines a User POCO class.
    /// </summary>
    internal class User
    {
        private int _id;
        private string? _username;
        private string? _email;
        private string? _password;

        public int Id { get { return _id; } set { _id = value; } }
        public string? Username { get { return _username; } set { _username = value; } }
        public string? Email { get { return _email; } set { _email = value; } }
        public string? Password { get { return _password; } set { _password = value; } }

        public User() 
        { 
        }

        public User(int id, string? username, string? email, string? password)
        {
            _id = id;
            _username = username;
            _email = email;
            _password = password;
        }
    }
}
