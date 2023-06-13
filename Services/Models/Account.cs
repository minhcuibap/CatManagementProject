using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Account
    {
        public Account()
        {
            Cats = new HashSet<Cat>();
            RegisteredServices = new HashSet<RegisteredService>();
        }

        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public int? RoleId { get; set; }

        public virtual ICollection<Cat> Cats { get; set; }
        public virtual ICollection<RegisteredService> RegisteredServices { get; set; }
    }
}
