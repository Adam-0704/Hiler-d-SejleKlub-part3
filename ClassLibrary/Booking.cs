using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Booking
    {
        public int BookingId { get; set; }
        public double StartDato { get; set; }
        public double SlutDato { get; set; }

        public Booking(int bookingid, double startdato, double slutdato )
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
}
