using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromDatabase
{
    public class ExistingReservations
    {
        public int ReservationID { get; set; }
        public DateTime ReservationDate { get; set; }
        public string GuestName { get; set; }
        public int TableID { get; set; }
    }
}
