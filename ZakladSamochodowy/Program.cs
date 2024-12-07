using Zaklad;



namespace ZakladSamochodowy
{

    internal class Program
    {
        public static List<Klient> ListaKlientow = new List<Klient>() {new Klient("Adam","Kowal","47658939"),new Klient("Jan","Nowak","678232438") };

        public static List<Samochod> ListaSamochodow = new List<Samochod>();
        private static void Main(string[] args)
        {
            FunkcjeHelpers.Menu();

            //Zaklad.Klient klient = new Zaklad.Klient();
            //klient.Imie="Jan";
            //klient.Nazwisko="Kowalski";
            //klient.Telefon="123456789";

            //Zaklad.Samochod samochod = new Zaklad.Samochod();
            //samochod.VIN="123456789";
            //samochod.Marka="Audi";
            //samochod.Model="A4";
            //samochod.NumerRejestracyjny="SK 3782564";
            //samochod.Wlasciciel=klient;

            //Console.WriteLine("Samochód: {0} {1} ", samochod.Model, samochod.Wlasciciel.Imie);


            //Zaklad.Pracownik pracownik = new Zaklad.Pracownik();
            //pracownik.Imie="Jan";
            //pracownik.Nazwisko="Nowak";
            //pracownik.Telefon="987654321";
            //pracownik.Specjalizacja=Specjalista.Lakiernik;
        }
    }
}
