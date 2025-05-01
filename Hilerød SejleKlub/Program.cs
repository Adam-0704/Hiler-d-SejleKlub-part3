
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
        static string blogIndhold = "Både i Hillerød Sejlklub – En Mangfoldig Flåde på Sjælsø\n" +
                            "Hillerød Sejlklub huser en bred vifte af både, der afspejler både tradition og moderne sejlads. Klubben ligger idyllisk placeret ved Sjælsø, og her finder man alt fra små joller og optimistbåde til kølbåde og turbåde, der egner sig til længere udflugter.\n" +
                            "For de yngste sejlere er optimistjollerne en fast del af hverdagen, mens de mere erfarne medlemmer ofte ses med hænderne på roret i en Yngling, Wayfarer eller en af klubbens kølbåde.\n" +
                            "Klubben råder over flere fællesbåde, som giver medlemmer mulighed for at sejle uden at eje deres egen båd. Det skaber et inkluderende miljø, hvor alle – uanset erfaring og udstyr – kan komme ud på vandet.\n" +
                            "Derudover arrangeres der jævnligt kapsejladser, hvor både af forskellige klasser mødes i venskabelig konkurrence.\n" +
                            "Bådeflåden i Hillerød Sejlklub er ikke bare et teknisk aktiv – den er en central del af klubbens fællesskab og kultur.";



        static void Main(string[] args)
        {

            Medlem Medlem1 = new Medlem(01, "Jonas Johansen", "Jonas2@yahoo.dk", 45305704);
            Medlem Medlem2 = new Medlem(02, "Emil carlsen", "Emil32@outlook.com", 22740724);
            Medlem Medlem3 = new Medlem(03, "Adam Sørensen", "AdamSør32@gmail.com", 53750704);

            medlemmer.Add(Medlem1);
            medlemmer.Add(Medlem2);
            medlemmer.Add(Medlem3);

            Båd Båd1 = new Båd(01, "Hanse 388", "Yanmar 29 HK diesel motor", "DEN 388", "Utætte luger og vinduer");
            Båd Båd2 = new Båd(02, "Bavaria cruiser 34", "Volvo Penta 28 hk dieselmotor", "DEN 1234", "Defekte Pumpe");
            Båd Båd3 = new Båd(03, "Sun Odyssey 410", "yannmar 40 hk dieselmotor", "DEN 520", "Fejler Intet");

            både.Add(Båd1);
            både.Add(Båd2);
            både.Add(Båd3);

            Begivenhed begivenhed1 = new Begivenhed(01, "SommerFest", new DateTime(2025, 6, 6), new DateTime(2025, 6, 7), "amager strand");
            Begivenhed begivenhed2 = new Begivenhed(02, "Fjordens festdag", new DateTime(2025, 6, 25), new DateTime(2025, 6, 26), "Roskilde Havn");
            Begivenhed begivenhed3 = new Begivenhed(03, "Øhavsregattaen", new DateTime(2025, 7, 5), new DateTime(2025, 7, 6), "Det Sydfysnke Øhav");


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

                Console.WriteLine("Vælg en af valmulighederne");
                Thread.Sleep(1000);

                Console.WriteLine("1:  Se medlemmer");
                Thread.Sleep(200);

                Console.WriteLine("2:  Opret medlem");
                Thread.Sleep(200);

                Console.WriteLine("3:  Se både");
                Thread.Sleep(200);

                Console.WriteLine("4:  Opret båd");
                Thread.Sleep(200);

                Console.WriteLine("5:  Se bookinger");
                Thread.Sleep(200);

                Console.WriteLine("6:  Opret booking");
                Thread.Sleep(200);

                Console.WriteLine("7:  Se begivnheder");
                Thread.Sleep(200);

                Console.WriteLine("8:  Opret begivenhed");
                Thread.Sleep(200);

                Console.WriteLine("9:  Rediger medlem");
                Thread.Sleep(200);

                Console.WriteLine("10: Blog afsnit");
                Thread.Sleep(200);

                Console.WriteLine("11: Rediger blog");
                Thread.Sleep(200);


                Console.WriteLine(new string('-', 120));


                int Valg = Convert.ToInt32(Console.ReadLine());

                switch (Valg)
                {
                    case 1: // se medlemmer
                        foreach (var Medlem in medlemmer)
                        {
                            Console.WriteLine(Medlem.ToString());
                            Console.WriteLine(new string('-', 120));
                        }
                        break;

                    case 2: // opret medlem
                        Console.WriteLine("Opret Medlem");
                        Thread.Sleep(1000);

                        Console.WriteLine("Indtast Navn");
                        string Navn = Console.ReadLine();

                        Console.WriteLine("Indtast Email ");
                        string Email = Console.ReadLine();

                        Console.WriteLine("Indtast telefon nr (ingen melemrum)");
                        int Telefon = Convert.ToInt32(Console.ReadLine());
                        var newID = medlemmer.Max(medlem => medlem.Id) + 1;
                        Medlem NytMedlem = new Medlem(newID, Navn, Email, Telefon);

                        medlemmer.Add(NytMedlem);

                        Console.WriteLine("\nNyt medlem tilføjet");
                        Console.WriteLine(NytMedlem.ToString());
                        Console.WriteLine(new string('-', 120));
                        Thread.Sleep(1200);
                        break;

                    case 3: // se både
                        foreach (var Båd in både)
                        {
                            Console.WriteLine(Båd.ToString());

                            Console.WriteLine(new string('-', 120));
                        }
                        break;

                    case 4: // Opret både
                        {

                            Console.WriteLine("Indtast navn på båden");
                            string navn = (Console.ReadLine());
                            Console.WriteLine("Indtast motor på båden)");
                            string motor = (Console.ReadLine());
                            Console.WriteLine("Indtast sejlnummer på båden");
                            string sejlnummer = (Console.ReadLine());
                            Console.WriteLine("Indtast problem (hvis intet fejler indtast ¨fejler intet¨)");
                            string problem = (Console.ReadLine());
                            Console.WriteLine("\nDu har nu oprettet en ny båd");
                            var newID4 = både.Max(båd => båd.Id) + 1;
                            Båd NyBåd = new Båd(newID4, navn, motor, sejlnummer, problem);
                            både.Add(NyBåd);
                            Console.WriteLine(new string('-', 120));
                            break;

                        }

                    case 5: // se bookinger
                        foreach (var Booking in bookinger)
                        {
                            Console.WriteLine(Booking.ToString());

                            Console.WriteLine(new string('-', 120));
                        }
                        break;

                    case 6:// opret booking
                        Console.WriteLine("Indtast Medlems Id");
                        int medlemid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast Båd Id");
                        int boatid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast Start Dato (dd-mm-yyyy)");
                        DateTime startdato = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Indstast Slut Dato (dd-mm.yyyy)");
                        DateTime slutdato = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("\nDu har nu oprettet en ny bookning");
                        var newID3 = bookinger.Max(booking => booking.BookingId) + 1;
                        Booking NyBooking = new Booking(newID3, boatid, medlemid, startdato, slutdato);
                        bookinger.Add(NyBooking);
                        Console.WriteLine(new string('-', 120));
                        break;

                    case 7: // se begivenheder
                        foreach (var Begivenhed in Begivenheder)
                        {
                            Console.WriteLine(Begivenhed.ToString());

                            Console.WriteLine(new string('-', 120));
                        }
                        break;

                    case 8: // opret begivenhed
                        Console.WriteLine("Indtast Medlems Id");
                        int medlemid2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("indtast begivenheds navn");
                        string Navn2 = Console.ReadLine();
                        Console.WriteLine("Indtast Start Dato (dd-mm-yyyy)");
                        DateTime startdato2 = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Indtast Slut Dato (dd-mm-yyyy)");
                        DateTime slutdato2 = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Indtast sted");
                        string sted = Console.ReadLine();

                        Begivenhed Nybegivenhed = new Begivenhed(medlemid2, Navn2, startdato2, slutdato2, sted);
                        var newID2 = Begivenheder.Max(begivenhed => begivenhed.Id) + 1;
                        Begivenheder.Add(Nybegivenhed);
                        Console.WriteLine("\nDu har nu oprettet en ny begivenhed!");

                        Console.WriteLine(new string('-', 120));
                        break;

                    case 9: // rediger medlem
                        Console.WriteLine("Indtast Medlems Id for det medlem, du vil redigere:");
                        int redigerId = Convert.ToInt32(Console.ReadLine());

                        var medlemTilRedigering = medlemmer.FirstOrDefault(medlem => medlem.Id == redigerId);

                        if (medlemTilRedigering != null)
                        {
                            Console.WriteLine("Hvad vil du redigere?");
                            Console.WriteLine("1: Navn ("+medlemTilRedigering.Navn+")");
                            Console.WriteLine("2: Email ("+medlemTilRedigering.Email+")");
                            Console.WriteLine("3: Telefon ("+medlemTilRedigering.Telefon+")");

                            int redigerValg = Convert.ToInt32(Console.ReadLine());

                            switch (redigerValg)
                            {
                                case 1:
                                    Console.WriteLine("Indtast nyt navn:");
                                    medlemTilRedigering.Navn = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.WriteLine("Indtast ny email:");
                                    medlemTilRedigering.Email = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Indtast nyt telefonnummer:");
                                    medlemTilRedigering.Telefon = Convert.ToInt32(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Ugyldigt valg.");
                                    break;
                            }

                            Console.WriteLine("Medlemmet er blevet opdateret:");
                        }
                        else
                        {
                            Console.WriteLine("Medlem med det angivne ID blev ikke fundet.");
                        }
                        break;

                    case 10: // Vis blogindhold
                        Console.WriteLine(blogIndhold);
                        Console.WriteLine(new string('-', 120));
                        break;

                    case 11: // Rediger blog

                        Console.WriteLine("Velkommen til Hillerød Sejlklubs Blog!");
                        Console.WriteLine("1: Se blogindhold");
                        Console.WriteLine("2: Rediger blogindhold");
                        int blogValg = Convert.ToInt32(Console.ReadLine());

                        switch (blogValg)
                        {
                            case 1: // Se blogindhold
                                Console.WriteLine(blogIndhold);
                                break;

                            case 2: // Rediger blogindhold
                                Console.WriteLine("Indtast nyt blogindhold:");
                                blogIndhold = Console.ReadLine();
                                Console.WriteLine("\nBlogindholdet er blevet opdateret:");
                                Console.WriteLine(blogIndhold);
                                break;

                            default:
                                Console.WriteLine("Ugyldigt valg.");
                                break;
                        }
                        Console.WriteLine(new string('-', 120));
                        break;
                }

            }
        }

    }
}

