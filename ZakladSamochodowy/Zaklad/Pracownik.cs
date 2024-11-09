namespace Zaklad{
    public struct Pracownik{
    public string Imie;
    public string Nazwisko;
    public string Telefon;
    public Specjalista Specjalizacja;
    }

    public enum Specjalista{
        Mechanik,
        Elektryk,
        Blacharz,
        Lakiernik,
        Kierownik,
        Ksiegowa
    }
}