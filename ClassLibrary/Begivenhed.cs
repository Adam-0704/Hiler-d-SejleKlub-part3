using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Begivenhed
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Sted { get; set; }
        public DateTime StartDato { get; set; }
        public DateTime SlutDato { get; set; }


        public Begivenhed(int id, string navn, DateTime startdato, DateTime slutdato, string sted)
        {
            Id = id;
            Navn = navn;
            Sted = sted;
            StartDato = startdato;
            SlutDato = slutdato;

        }

        public override string ToString()
        {
            return $"Id: {Id}, Navn: {Navn}, Sted: {Sted}, Start dato: {StartDato}, Slut dato{SlutDato}";
        }
    }

}
