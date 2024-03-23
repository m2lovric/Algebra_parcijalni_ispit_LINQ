using Ispit.Model.Klase;

namespace Ispit.Model;

public class Podaci
{
    public List<Banka> ListaBanki = new List<Banka>()
    {
        new Banka { Simbol = "JPM", Naziv = "JPMorgan Chase" },
        new Banka { Simbol = "BOJ", Naziv = "Bank of Japan" },
        new Banka { Simbol = "HSBC", Naziv = "HSBC Holdings" },
    };

    public List<Klijent> ListaKlijenata = new List<Klijent>()
    {
        new Klijent { ImePrezime = "Marko Marković", Stanje = 1000000.01, Banka = "HSBC" },
        new Klijent { ImePrezime = "Hana Horvatić", Stanje = 54231.78, Banka = "HSBC" },
        new Klijent { ImePrezime = "Ivan Ivić", Stanje = 873219.42, Banka = "HSBC" },
        new Klijent { ImePrezime = "Josip Jurić", Stanje = 1987123.99, Banka = "JPM" },
        new Klijent { ImePrezime = "Ana Anić", Stanje = 21345.67, Banka = "JPM" },
        new Klijent { ImePrezime = "Ante Antić", Stanje = 1234567.89, Banka = "JPM" },
        new Klijent { ImePrezime = "Ema Erić", Stanje = 423123.45, Banka = "BOJ" },
        new Klijent { ImePrezime = "Petar Petrović", Stanje = 789321.00, Banka = "BOJ" },
        new Klijent { ImePrezime = "Lucija Lucić", Stanje = 1592872.31, Banka = "BOJ" },
        new Klijent { ImePrezime = "Sandra Stanić", Stanje = 45678.90, Banka = "HSBC" },
    };
}