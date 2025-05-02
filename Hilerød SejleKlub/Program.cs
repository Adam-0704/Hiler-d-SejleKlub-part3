using System;
using System.Collections.Generic;
using System.Security;
using ClassLibrary;
using ClassLibrary.Repositories;

namespace Hilerød_SejleKlub
{
    internal class Program
    {
        static string blogIndhold = "Både i Hillerød Sejlklub – En Mangfoldig Flåde på Sjælsø\n" +
                            "Hillerød Sejlklub huser en bred vifte af både, der afspejler både tradition og moderne sejlads. Klubben ligger idyllisk placeret ved Sjælsø, og her finder man alt fra små joller og optimistbåde til kølbåde og turbåde, der egner sig til længere udflugter.\n" +
                            "For de yngste sejlere er optimistjollerne en fast del af hverdagen, mens de mere erfarne medlemmer ofte ses med hænderne på roret i en Yngling, Wayfarer eller en af klubbens kølbåde.\n" +
                            "Klubben råder over flere fællesbåde, som giver medlemmer mulighed for at sejle uden at eje deres egen båd. Det skaber et inkluderende miljø, hvor alle – uanset erfaring og udstyr – kan komme ud på vandet.\n" +
                            "Derudover arrangeres der jævnligt kapsejladser, hvor både af forskellige klasser mødes i venskabelig konkurrence.\n" +
                            "Bådeflåden i Hillerød Sejlklub er ikke bare et teknisk aktiv – den er en central del af klubbens fællesskab og kultur.";

        static void Main(string[] args)
        {
            // Opret repository-objekter
            var medlemRepo = new MedlemRepository();
            var bådRepo = new BådRepository();
            var bookingRepo = new BookingRepository();
            var begivenhedRepo = new BegivenhedRepository();

            // Tilføj data til repositories
            medlemRepo.Add(new Medlem(1, "Jonas Johansen", "Jonas2@yahoo.dk", 45305704));
            medlemRepo.Add(new Medlem(2, "Emil Carlsen", "Emil32@outlook.com", 22740724));
            medlemRepo.Add(new Medlem(3, "Adam Sørensen", "AdamSør32@gmail.com", 53750704));

            bådRepo.Add(new Båd(1, "Hanse 388", "Yanmar 29 HK diesel motor", "DEN 388", "Utætte luger og vinduer"));
            bådRepo.Add(new Båd(2, "Bavaria cruiser 34", "Volvo Penta 28 hk dieselmotor", "DEN 1234", "Defekte Pumpe"));
            bådRepo.Add(new Båd(3, "Sun Odyssey 410", "Yanmar 40 hk dieselmotor", "DEN 520", "Fejler Intet"));

            begivenhedRepo.Add(new Begivenhed(1, "SommerFest", new DateTime(2025, 6, 6), new DateTime(2025, 6, 7), "Amager Strand"));
            begivenhedRepo.Add(new Begivenhed(2, "Fjordens festdag", new DateTime(2025, 6, 25), new DateTime(2025, 6, 26), "Roskilde Havn"));
            begivenhedRepo.Add(new Begivenhed(3, "Øhavsregattaen", new DateTime(2025, 7, 5), new DateTime(2025, 7, 6), "Det Sydfynske Øhav"));

            bookingRepo.Add(new Booking(1, 1, 1, new DateTime(2025, 6, 1), new DateTime(2025, 6, 2)));
            bookingRepo.Add(new Booking(2, 2, 2, new DateTime(2025, 6, 3), new DateTime(2025, 6, 4)));
            bookingRepo.Add(new Booking(3, 3, 3, new DateTime(2025, 6, 5), new DateTime(2025, 6, 6)));

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

                Console.WriteLine("3:  Rediger medlem");
                Thread.Sleep(200);

                Console.WriteLine("4:  Se både");
                Thread.Sleep(200);

                Console.WriteLine("5:  Opret båd");
                Thread.Sleep(200);

                Console.WriteLine("6:  Rediger båd");
                Thread.Sleep(200);

                Console.WriteLine("7:  Se bookinger");
                Thread.Sleep(200);

                Console.WriteLine("8:  Opret booking");
                Thread.Sleep(200);

                Console.WriteLine("9:  Se begivenheder");
                Thread.Sleep(200);

                Console.WriteLine("10: Opret begivenhed");
                Thread.Sleep(200);

                Console.WriteLine("11: Rediger bookninger");
                Thread.Sleep(200);

                Console.WriteLine("12: Blog afsnit");
                Thread.Sleep(200);

                Console.WriteLine("13: Rediger blog");
                Thread.Sleep(200);


                Console.WriteLine(new string('-', 120));


                int Valg = Convert.ToInt32(Console.ReadLine());

                switch (Valg)
                {
                    case 1: // se medlemmer
                        foreach (var Medlem in medlemRepo.GetAll())
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
                        var newID = medlemRepo.GetAll().Max(medlem => medlem.Id) + 1;
                        Medlem NytMedlem = new Medlem(newID, Navn, Email, Telefon);

                        medlemRepo.Add(NytMedlem);

                        Console.WriteLine("\nNyt medlem tilføjet");
                        Console.WriteLine(NytMedlem.ToString());
                        Console.WriteLine(new string('-', 120));
                        Thread.Sleep(1200);
                        break;

                    case 3: // rediger medlem
                        Console.WriteLine("Indtast Medlems Id for det medlem, du vil redigere:");
                        int redigerId = Convert.ToInt32(Console.ReadLine());

                        var medlemTilRedigering = medlemRepo.GetAll().FirstOrDefault(medlem => medlem.Id == redigerId);

                        if (medlemTilRedigering != null)
                        {
                            Console.WriteLine("Hvad vil du redigere?");
                            Console.WriteLine("1: Navn (" + medlemTilRedigering.Navn + ")");
                            Console.WriteLine("2: Email (" + medlemTilRedigering.Email + ")");
                            Console.WriteLine("3: Telefon (" + medlemTilRedigering.Telefon + ")");

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

                    case 4: // se både
                        foreach (var Båd in bådRepo.GetAll())
                        {
                            Console.WriteLine(Båd.ToString());

                            Console.WriteLine(new string('-', 120));
                        }
                        break;

                    case 5: // Opret både
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
                            var newID4 = bådRepo.GetAll().Max(båd => båd.Id) + 1;
                            Båd NyBåd = new Båd(newID4, navn, motor, sejlnummer, problem);
                            bådRepo.Add(NyBåd);
                            Console.WriteLine(new string('-', 120));
                            break;

                        }
                    case 6: // rediger båd
                        {
                            Console.WriteLine("indtast båd id:");
                            int redigerbådId = Convert.ToInt32(Console.ReadLine());

                            var bådTilRedigering = bådRepo.GetAll().FirstOrDefault(bådRepo => bådRepo.Id == redigerbådId);

                            if (bådTilRedigering != null)
                            {

                                Console.WriteLine("Hvad vil du redigere?");
                                Console.WriteLine("1: Navn");
                                Console.WriteLine("2: moter");
                                Console.WriteLine("3: sejlnummer");
                                Console.WriteLine("4: problemet");

                                int redigerValg2 = Convert.ToInt32(Console.ReadLine());

                                switch (redigerValg2)
                                {
                                    case 1:
                                        Console.WriteLine("Indtast nyt navn:");
                                        bådTilRedigering.Navn = Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("Indtast ny motor:");
                                        bådTilRedigering.Motor = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("Indtast nyt sejlnummer:");
                                        bådTilRedigering.SejlNummer = (Console.ReadLine());
                                        break;
                                    case 4:
                                        Console.WriteLine("indtast problemet hvis intet fejler indtast ¨fejler intet¨");
                                        bådTilRedigering.Problem = Console.ReadLine();
                                        break;
                                    default:
                                        Console.WriteLine("Ugyldigt valg.");

                                        Console.WriteLine("Båd er blevet opdateret:");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Båd med det angivne ID blev ikke fundet.");
                            }
                        }

                        break;


                    case 7: // se bookinger




                        foreach (var Booking in bookingRepo.GetAll())
                        {
                            Console.WriteLine(Booking.ToString());

                            Console.WriteLine(new string('-', 120));
                        }
                        break;

                    case 8:// opret booking
                        Console.WriteLine("Indtast Medlems Id");
                        int medlemid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast Båd Id");
                        int boatid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indtast Start Dato (dd-mm-yyyy)");
                        DateTime startdato = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Indstast Slut Dato (dd-mm.yyyy)");
                        DateTime slutdato = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("\nDu har nu oprettet en ny bookning");
                        var newID3 = bookingRepo.GetAll().Max(booking => booking.BookingId) + 1;
                        Booking NyBooking = new Booking(newID3, boatid, medlemid, startdato, slutdato);
                        bookingRepo.Add(NyBooking);
                        Console.WriteLine(new string('-', 120));
                        break;

                    case 9: // se begivenheder
                        foreach (var Begivenhed in begivenhedRepo.GetAll())
                        {
                            Console.WriteLine(Begivenhed.ToString());

                            Console.WriteLine(new string('-', 120));
                        }
                        break;

                    case 10: // opret begivenhed
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
                        var newID2 = begivenhedRepo.GetAll().Max(begivenhed => begivenhed.Id) + 1;
                        begivenhedRepo.Add(Nybegivenhed);
                        Console.WriteLine("\nDu har nu oprettet en ny begivenhed!");

                        Console.WriteLine(new string('-', 120));
                        break;

                    case 11:// rediger bookninger
                        Console.WriteLine("indtast booking id:");
                        int redigerbookingId = Convert.ToInt32(Console.ReadLine());

                        var BookingTilRedigering = bookingRepo.GetAll().FirstOrDefault(booking => booking.BookingId == redigerbookingId);

                        if (BookingTilRedigering != null)
                        {
                            Console.WriteLine("Hvad vil du redigere?");
                            Console.WriteLine("1: boat ID");
                            Console.WriteLine("2: medlem ID");
                            Console.WriteLine("3: Start Dato");
                            Console.WriteLine("4: Slut Dato");

                            int redigerValg3 = Convert.ToInt32(Console.ReadLine());

                            switch (redigerValg3)
                            {
                                case 1:
                                    Console.WriteLine("Indtast nyt boat ID:");
                                    BookingTilRedigering.BoatId = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 2:
                                    Console.WriteLine("Indtast nyt medlem ID:");
                                    BookingTilRedigering.MedlemId = Convert.ToInt32(Console.ReadLine());
                                    break;
                                case 3:
                                    Console.WriteLine("Indtast Start Dato (dd-mm-yyyy);");
                                    BookingTilRedigering.StartDato = Convert.ToDateTime(Console.ReadLine());
                                    break;
                                case 4:
                                    Console.WriteLine("(Indtast slut Dato (dd-mm-yyyy)");
                                    BookingTilRedigering.SlutDato = Convert.ToDateTime(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Ugyldigt valg.");
                                    break;
                            }
                            Console.WriteLine("booking er blevet opdateret:");
                        }


                        else
                        {
                            Console.WriteLine("Booking med det angivne ID blev ikke fundet.");
                        }
                        break;



                    case 12: // Vis blogindhold
                        Console.WriteLine(blogIndhold);
                        Console.WriteLine(new string('-', 120));
                        break;

                    case 13: // Rediger blog

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

