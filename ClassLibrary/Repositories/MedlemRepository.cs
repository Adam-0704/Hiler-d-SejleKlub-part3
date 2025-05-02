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



    }
}