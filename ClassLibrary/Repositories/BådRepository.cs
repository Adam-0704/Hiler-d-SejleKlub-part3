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

        
    }
}