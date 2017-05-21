using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactHubAPI.Models.User
{
    public class LoginUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Grant_Type => "password";
    }
}