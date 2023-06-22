using System;
using System.Collections.Generic;

#nullable disable

namespace Services.Models
{
    public partial class RegisteredService
    {
        public int RegisteredId { get; set; }
        public int? AccountId { get; set; }
        public int? CatId { get; set; }
        public int? ServiceId { get; set; }
        public DateTime? Date { get; set; }
        public int? Status { get; set; }

        //public virtual Account Account { get; set; }
        //public virtual Cat Cat { get; set; }
        //public virtual Service Service { get; set; }
    }
}
