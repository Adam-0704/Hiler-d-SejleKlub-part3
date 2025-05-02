using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.Repositories
{
    public class BådRepository
    {
        private List<Båd> både = new();

        public List<Båd> GetAll()
        {
            return både;
        }

        public void Add(Båd båd)
        {
            både.Add(båd);
        }

        public Båd GetById(int id)
        {
            foreach (var båd in både)
            {
                if (båd.Id == id)
                {
                    return båd;
                }
            }
            return null; // Returner null, hvis ingen match findes
        }
    }
}