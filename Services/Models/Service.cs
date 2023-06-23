using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class Service
    {
        // public Service()
        // {
        //     RegisteredServices = new HashSet<RegisteredService>();
        // }

        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public int? ServicePrice { get; set; }

        // public virtual ICollection<RegisteredService> RegisteredServices { get; set; }
    }
}
