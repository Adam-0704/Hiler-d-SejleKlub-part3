
using System;
using System.Collections.Generic;
using System.Security;
using ClassLibrary;

namespace Hilerød_SejleKlub
{
    internal class Program
    {
       static List<Medlem> medlemmer = new();
       static List<Båd> både = new();
       static List<Booking> bookinger = new();
       static List<Begivenhed> Begivenheder = new();



        static void Main(string[] args)
        {

            Medlem Medlem1 = new Medlem(01, "Jonas Johansen", "Jonas2@yahoo.dk", 45305704 );
            Medlem Medlem2 = new Medlem(02, "Emil carlsen", "Emil32@outlook.com", 22740724);
            Medlem Medlem3 = new Medlem(03,"Adam Sørensen" , "AdamSør32@gmail.com", 53750704);

            medlemmer.Add(Medlem1);
            medlemmer.Add(Medlem2);
            medlemmer.Add(Medlem3);

            Båd Båd1 = new Båd(01, "Hanse 388", "Yanmar 29 HK diesel motor","DEN 388", "Utætte luger og vinduer");
            Båd Båd2 = new Båd(02, "Bavaria cruiser 34", "Volvo Penta 28 hk dieselmotor","DEN 1234","Defekte Pumpe");
            Båd Båd3 = new Båd(03, "Sun Odyssey 410", "yannmar 40 hk dieselmotor", "DEN 520" , "Fejler Intet");

            både.Add(Båd1);
            både.Add(Båd2);
            både.Add(Båd3);

            Begivenhed begivenhed1 = new Begivenhed(01,"SommerFest", new DateTime(2025,6,6), "amager strand");
            Begivenhed begivenhed2 = new Begivenhed(02, "Fjordens festdag", new DateTime(2025,6,25), "Roskilde Havn");
            Begivenhed begivenhed3 = new Begivenhed(03, "Øhavsregattaen", new DateTime(2025,7,5), "Det Sydfysnke Øhav");

            Begivenheder.Add(begivenhed1);
            Begivenheder.Add(begivenhed2);
            Begivenheder.Add(begivenhed3);

            Booking booking1 = new Booking(01, 01, 01, new DateTime(2025, 6, 1), new DateTime(2025, 6, 2));
            Booking booking2 = new Booking(02, 02, 02, new DateTime(2025, 6, 3), new DateTime(2025, 6, 4));
            Booking booking3 = new Booking(03, 03, 03, new DateTime(2025, 6, 5), new DateTime(2025, 6, 6));

            bookinger.Add(booking1);
            bookinger.Add(booking2);
            bookinger.Add(booking3);


            Console.WriteLine("Velkommen til Hilerød SejleKlub");
            Thread.Sleep(1000);

            bool running = true;

            while (running == true)
            {

                Console.WriteLine("vælg en af valmulighederne");
                Thread.Sleep(1000);

                Console.WriteLine("1:  se medlemmer");
                Thread.Sleep(200);

                Console.WriteLine("2:  opret medlem");
                Thread.Sleep(200);

                Console.WriteLine("3:  se både");
                Thread.Sleep(200);

                Console.WriteLine("4:  se bookinger");
                Thread.Sleep(200);

                Console.WriteLine("5:  opret booking");
                Thread.Sleep(200);

                Console.WriteLine("6:  se begivnheder");
                Thread.Sleep(200);

                Console.WriteLine("7:  opret begivenhed");
                Thread.Sleep(200);



                int Valg = Convert.ToInt32(Console.ReadLine());

                if (Valg == 1) /* her vises der en liste over alle medlemmer */
                {
                    foreach (var Medlem in medlemmer)
                    {
                        Console.WriteLine(Medlem.ToString());
                    }

                }
                else if (Valg == 2) /* her er der mulighed for at oprette en ny medlem til SejleKlubben */
                {
                    Console.WriteLine("opret Medlem");
                    Thread.Sleep(1000);

                    Console.WriteLine("indtast Navn");
                    string Navn = Console.ReadLine();

                    Console.WriteLine("Indtast Email ");
                    string Email = Console.ReadLine();

                    Console.WriteLine("Indtast telefon nr (ingen melemrum)");
                    int Telefon = Convert.ToInt32(Console.ReadLine());
                    var newID = medlemmer.Max(medlem => medlem.Id) + 1; //måske fjernes
                    Medlem NytMedlem = new Medlem(newID, Navn, Email, Telefon);

                    medlemmer.Add(NytMedlem);

                    Console.WriteLine("\nnyt medlem tilføjet");
                    Console.WriteLine(NytMedlem.ToString());
                    Thread.Sleep(1200);



                }
                else if (Valg == 3) /* her vises der en liste over alle de både som Sejleklubben har samt deres fejl(defekter osv)*/
                {
                    foreach (var Båd in både)
                    {

                        Console.WriteLine(Båd.ToString());
                    }

                }
                else if (Valg == 4) /* se bookinger*/
                {

                    foreach (var Booking in bookinger)
                    {
                        Console.WriteLine(Booking.ToString());
                    }
                }


                else if (Valg == 5) /* opret booking */
                {
                
                    Console.WriteLine("Indtast Medlems Id");
                    int medlemid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indtast Båd Id");
                    int boatid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indtast Start Dato (dd-mm-yyyy)");
                    DateTime startdato = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Indstast Slut Dato (dd-mm.yyyy)");
                    DateTime slutdato = Convert.ToDateTime(Console.ReadLine());
                    // 1. Switch Case
                    // Still spørgsmål 1. MedlemsId, boatId, Start og slut dato,
                    /* Spørgsmål 2. Ledige Tider? True /false. Brug listen bookinger til at Where()
                     og bool true/false (boatId, start tid og slut tid) */
                    // Spørgsmål 3. Hvis ja så får du besked om den er booket, hvis nej start forfra.
                    // Bool if true if false (String CW besked tilbage)


                }
                else if (Valg == 6) /* se begivenehder */
                {

                    foreach (var Begivenhed in Begivenheder)
                    {
                        Console.WriteLine(Begivenhed.ToString());
                    }

                }
                else if (Valg == 7) /* opret begivenheder */
                {


                }
                else
                {
                    Console.WriteLine("please enter The valid numbers");
                }
            }

        }
    }
}
