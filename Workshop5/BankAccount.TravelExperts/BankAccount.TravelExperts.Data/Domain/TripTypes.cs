using System;
using System.Collections.Generic;

namespace BankAccount.TravelExperts.Data.Domain
{
    public partial class TripTypes
    {
        public TripTypes()
        {
            Bookings = new HashSet<Bookings>();
        }

        public string TripTypeId { get; set; }
        public string Ttname { get; set; }

        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
