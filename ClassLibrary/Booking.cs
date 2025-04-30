using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class LedigBooking
    {
        public int BookingId { get; set; }
        public int BoatId { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }

        public LedigBooking(int bookingid, int boatid, DateTime startdato, DateTime slutdato )
        {
            BookingId = bookingid;
            BoatId = BoatId;
            StartDato = startdato;
            SlutDato = slutdato;
            
        }


        public override string ToString()
        {
            return $"Id: {BookingId}";
        }


    }       
}
