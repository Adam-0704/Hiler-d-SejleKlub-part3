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

        
    }
}