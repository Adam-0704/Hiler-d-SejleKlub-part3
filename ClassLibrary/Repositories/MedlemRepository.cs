using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.Repositories
{
    public class MedlemRepository
    {
        private List<Medlem> medlemmer = new();

        public List<Medlem> GetAll()
        {
            return medlemmer;
        }

        public void Add(Medlem medlem)
        {
            medlemmer.Add(medlem);
        }

        public Medlem GetById(int id)
        {
            foreach (var medlem in medlemmer)
            {
                if (medlem.Id == id)
                {
                    return medlem;
                }
            }
            return null; // Returner null, hvis ingen match findes
        }

        public void Update(Medlem medlem)
        {
            var existingMedlem = GetById(medlem.Id);
            if (existingMedlem != null)
            {
                existingMedlem.Navn = medlem.Navn;
                existingMedlem.Email = medlem.Email;
                existingMedlem.Telefon = medlem.Telefon;
            }
        }
    }
}