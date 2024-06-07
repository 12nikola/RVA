using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModel
{
    public class LogInModel
    {
        public string Error { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private string username1;
        public LogInModel(string error, string username, string password, string username1)
        {
            Error = error;
            Username = username;
            Password = password;
            this.username1 = username1;
        }
    }
}
