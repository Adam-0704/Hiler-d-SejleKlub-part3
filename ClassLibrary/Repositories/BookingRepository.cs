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

        public Booking GetById(int id)
        {
            foreach (var booking in bookinger)
            {
                if (booking.BookingId == id)
                {
                    return booking;
                }
            }
            return null; // Returner null, hvis ingen match findes
        }
    }
}