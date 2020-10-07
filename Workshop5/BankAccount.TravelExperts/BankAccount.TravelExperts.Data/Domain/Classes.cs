using System;
using System.Collections.Generic;

namespace BankAccount.TravelExperts.Data.Domain
{
    public partial class Classes
    {
        public Classes()
        {
            BookingDetails = new HashSet<BookingDetails>();
        }

        public string ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassDesc { get; set; }

        public virtual ICollection<BookingDetails> BookingDetails { get; set; }
    }
}
