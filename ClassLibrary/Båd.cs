using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Båd
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Motor { get; set; }
        public string SejlNummer { get; set; }
        public string Problem { get; set; }


        public Båd(int id, string navn, string motor, string sejlnummer, string problem )
        {
            Id = id;
            Navn = navn;
            Motor = motor;
            SejlNummer = sejlnummer;
            Problem = problem;
        }


        public override string ToString()
        {
            return $"Id: {Id}, Navn: {Navn}, Motor: {Motor}, SejlNummer: {SejlNummer}, Bådens Fejl: {Problem}";
        }

    }
}
