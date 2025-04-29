using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Medlem
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public string Email { get; set; }
        public int Telefon { get; set; }

        public Medlem(int id, string navn, string email, int telefon)
        {
            Id = id;
            Navn = navn;
            Email = email;
            Telefon = telefon;
        }

       
        
        public override string ToString()
        {
            return $"Id: {Id}, Navn: {Navn}, Email: {Email}, Telefon: {Telefon}";
        }

    }
}
