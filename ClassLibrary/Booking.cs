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
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }

        public LedigBooking(int bookingid, DateTime startdato, DateTime slutdato )
        {
            BookingId = bookingid;
            StartDato = startdato;
            SlutDato = slutdato;
            
        }


        public override string ToString()
        {
            return $"Id: {BookingId}";
        }


    }
    public class OptagetBooking
    {
        public int BookingId { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }

        public OptagetBooking(int bookingid, DateTime startdato, DateTime slutdato)
        {
            BookingId = bookingid;
            StartDato = startdato;
            SlutDato = slutdato;
        }
    }
}
