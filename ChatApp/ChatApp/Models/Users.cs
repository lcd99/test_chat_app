using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApp.Models
{
    public class Users
    {
        string _connectionId;
        string _username;

        public string ConnectionId { get => _connectionId; set => _connectionId = value; }
        public string Username { get => _username; set => _username = value; }
    }
}
