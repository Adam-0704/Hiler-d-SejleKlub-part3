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
        public int BoatId { get; set; }
        public int MedlemId { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }

        public Booking(int bookingid, int boatid, int medlemid, DateTime startdato, DateTime slutdato )
        {
            BookingId = bookingid;
            BoatId = boatid;
            MedlemId = medlemid;
            StartDato = startdato;
            SlutDato = slutdato;
            
        }


        public override string ToString()
        {
            return $"Id: {BookingId}, Båd Id: {BoatId}, Medlem Id: {MedlemId}, Start Dato: {StartDato}, Slut Dato {SlutDato}";
        }


    }       
}
