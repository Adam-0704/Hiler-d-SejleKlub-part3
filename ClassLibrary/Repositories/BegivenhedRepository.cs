using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.Repositories
{
    public class BegivenhedRepository
    {
        private List<Begivenhed> begivenheder = new();

        public List<Begivenhed> GetAll()
        {
            return begivenheder;
        }

        public void Add(Begivenhed begivenhed)
        {
            begivenheder.Add(begivenhed);
        }


       
    }
}