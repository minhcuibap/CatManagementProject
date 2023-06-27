using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Cat
    {
        public Cat()
        {
            RegisteredServices = new HashSet<RegisteredService>();
        }

        public int CatId { get; set; }
        public int? AccountId { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Sex { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<RegisteredService> RegisteredServices { get; set; }
    }
}
