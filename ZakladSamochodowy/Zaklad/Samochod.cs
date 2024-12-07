

namespace Zaklad{
    public struct Samochod
    {
        public string VIN;
        public string Marka;
        public string Model;
        public string NumerRejestracyjny;
        public Klient Wlasciciel;

        public Samochod(string vin, string marka, string model, string numerRejestracyjny,Klient klient)
        {
            VIN = vin;
            Marka = marka;
            Model = model;
            NumerRejestracyjny = numerRejestracyjny;
            Wlasciciel = klient;
        }
    }
}
