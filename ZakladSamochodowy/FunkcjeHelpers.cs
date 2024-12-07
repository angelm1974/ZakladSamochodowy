using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Zaklad;

namespace ZakladSamochodowy
{
    public static class FunkcjeHelpers
    {

        public static void wyswietlOpcjeMenu()
        {
            string[] menuItems = new string[]
            {
                "===MENU===",
                "1. Dodaj klienta",
                "2. Lista klientów",
                "3. Dodaj samochód",
                "4. Oddaj samochód do serwisu",
                "===NARZĘDZIA===",
                "5. Dodaj pracownika",
                "6. Lista pracowników",
                "7. Przydziel pracownika",
                "8. Rozlicz",
                "9. Wyjście"
            };  
            Console.Clear();
            foreach (var item in menuItems)
            {
                Wyswietl(item);
            }

            //string menu = "===MENU===\n"
                //+ "1. Dodaj klienta\n"
                //+ "2. Lista klientów\n"
                //+ "3. Dodaj samochód\n"
                //+ "4. Oddaj samochód do serwisu\n"
                //+ "==NARZĘDZIA==\n"
                //+ "5. Dodaj pracownika\n"
                //+ "6. Lista pracowników\n"
                //+ "7. Przydziel pracownika\n"
                //+ "8. Rozlicz\n"
                //+ "9. Wyjście\n"
                //+ "Wybierz opcję: (1-9)";
            //Console.WriteLine(menu);

       
        }

        public static void Menu() 
        {
            int wybor = 0;

            while (wybor != 9)
            {
                wyswietlOpcjeMenu();
                wybor = wyborUzytkownika();

                switch (wybor)
                {
                    case 1:
                        dodajKlienta();
                        break;
                    case 2:
                        wyswietlKlienta();
                        break;
                    case 3:
                       dodajSamochod();
                        break;
                    case 4:
                        Console.WriteLine("Oddaj samochód do serwisu");
                        break;
                    case 5:
                        Console.WriteLine("Dodaj pracownika");
                        break;
                    case 6:
                        Console.WriteLine("Lista pracowników");
                        break;
                    case 7:
                        Console.WriteLine("Przydziel pracownika");
                        break;
                    case 8:
                        Console.WriteLine("Rozlicz");
                        break;
                    case 9:
                        Console.WriteLine("Wyjście");
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy wybór");
                        break;
                }
                Console.ReadKey();
            }
        }

        static int wyborUzytkownika()
        {
            string? input = Console.ReadKey().KeyChar.ToString();
            Console.Clear();
            int liczba;

            if ( !string.IsNullOrEmpty(input) && int.TryParse(input, out liczba))
            {
                return liczba;
            }
            else
            {
                return -1;
            }
        }

        static void Wyswietl(string dane)
        {
            Console.WriteLine(dane);
        }

        static int WyswietlListe<T>(string tytul, List<T> pozycje,string komunikat)
        {
            Wyswietl(tytul);

            for (int i = 0; i < pozycje.Count; i++)
            {
                Wyswietl($"{i + 1}. {pozycje[i]}");
            }
            int numer = PobierzDane<int>(komunikat);

            return numer;
        }

        static T PobierzDane<T>(string komunikat) 
        {
            while (true) 
            {
                try
                {
                    Wyswietl(komunikat);
                    string? dane = Console.ReadLine();

                    if (string.IsNullOrEmpty(dane))
                    {
                        Wyswietl("Pole nie może być puste");
                        continue;
                    }
                    var wynik =(T)Convert.ChangeType(dane, typeof(T));
                    return wynik;
                }
                catch (Exception)
                {
                    Wyswietl("Twoje dane są nieprawidłowe!!! Popraw je i spróbuj ponownie.");
                }
            }
        }

        static void dodajKlienta()
        {
            string imie = PobierzDane<string>("Podaj imię klienta");
            string nazwisko = PobierzDane<string>("Podaj nazwisko klienta");
            string telefon = PobierzDane<string>("Podaj telefon klienta");
            Program.ListaKlientow.Add(new Zaklad.Klient(imie, nazwisko, telefon));
            Wyswietl($"Dodano klienta: {imie} {nazwisko} {telefon}");
        }

        static void wyswietlKlienta()
        {
            Console.Clear();
            foreach (var klient in Program.ListaKlientow)
            {
                Wyswietl($"Klient Imie: {klient.Imie}, Nazwisko {klient.Nazwisko}, Telefon {klient.Telefon}");
            }
        }

        static void dodajSamochod()
        {
            string vin = PobierzDane<string>("Podaj VIN samochodu");
            string marka = PobierzDane<string>("Podaj markę samochodu");
            string model = PobierzDane<string>("Podaj model samochodu");
            string numerRejestracyjny = PobierzDane<string>("Podaj numer rejestracyjny samochodu");
            List<string> do_wyswietlenia = Program.ListaKlientow.Select(k => $"{k.Imie} {k.Nazwisko}").ToList();
            int wybranyNumer =WyswietlListe<string>("Wybierz właściciela samochodu", do_wyswietlenia, "Wybierz numer właściciela samochodu");
            Klient wlasciciel = Program.ListaKlientow[wybranyNumer - 1];


            Program.ListaSamochodow.Add(new Zaklad.Samochod(vin, marka, model, numerRejestracyjny, wlasciciel));
            Wyswietl($"Dodano samochód: {vin} {marka} {model} {numerRejestracyjny} {wlasciciel.Nazwisko}");
        }
    }
}
