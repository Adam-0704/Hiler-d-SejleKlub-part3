using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary.Repositories
{
    public class B�dRepository
    {
        private List<B�d> b�de = new();

        public List<B�d> GetAll()
        {
            return b�de;
        }

        public void Add(B�d b�d)
        {
            b�de.Add(b�d);
        }

        public B�d GetById(int id)
        {
            foreach (var b�d in b�de)
            {
                if (b�d.Id == id)
                {
                    return b�d;
                }
            }
            return null; // Returner null, hvis ingen match findes
        }
    }
}