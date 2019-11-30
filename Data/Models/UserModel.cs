using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string ProfilePicture { get; set; }
        public string Type { get; set; }
        public string Password { get; set; }
    }
}
