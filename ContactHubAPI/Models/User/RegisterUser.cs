using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactHubAPI.Models.User
{
    public class RegisterUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
    }
}