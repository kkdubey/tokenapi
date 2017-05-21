using ContactHub.CoreData.Identity;
using System.ComponentModel.DataAnnotations;

namespace ContactHub.CoreData.Entities.Annonymous
{
    public class User : UserIdentity
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        [Key]
        public string EmailAddress { get; set; }
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
