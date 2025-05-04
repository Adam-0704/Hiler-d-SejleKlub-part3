using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.Repositories
{
    public class BookingRepository
    {
        private List<Booking> bookinger = new();

        public List<Booking> GetAll()
        {
            return bookinger;
        }

        public void Add(Booking booking)
        {
            bookinger.Add(booking);
        }


  
    }
}