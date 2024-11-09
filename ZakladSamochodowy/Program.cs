using Zaklad;

internal class Program
{
    private static void Main(string[] args)
    {
        Zaklad.Klient klient = new Zaklad.Klient();
        klient.Imie="Jan";
        klient.Nazwisko="Kowalski";
        klient.Telefon="123456789";

        Zaklad.Samochod samochod = new Zaklad.Samochod();
        samochod.VIN="123456789";
        samochod.Marka="Audi";
        samochod.Model="A4";
        samochod.NumerRejestracyjny="SK 3782564";
        samochod.Wlasciciel=klient;

        Console.WriteLine("Samochód: {0} {1} ", samochod.Model, samochod.Wlasciciel.Imie);


        Zaklad.Pracownik pracownik = new Zaklad.Pracownik();
        pracownik.Imie="Jan";
        pracownik.Nazwisko="Nowak";
        pracownik.Telefon="987654321";
        pracownik.Specjalizacja=Specjalista.Lakiernik;
    }
}