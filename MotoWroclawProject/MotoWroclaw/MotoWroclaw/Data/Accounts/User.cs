using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotoWroclaw.Data.Accounts
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }       
    }
}
