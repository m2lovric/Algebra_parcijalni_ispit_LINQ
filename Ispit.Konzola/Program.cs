﻿namespace Ispit.Konzola;
using Ispit.Model;

class Program
{
    static void Main(string[] args)
    {
        Podaci podaci = new Podaci();
        var klijenti = podaci.ListaKlijenata;
        var banke = podaci.ListaBanki;
        
        var GrupirajPremaBanci = from milijunas in klijenti
            where milijunas.Stanje >= 1000000
            group milijunas by milijunas.Banka 
            into grupaMilijunasa
            select new
            {
                Banka = grupaMilijunasa.Key,
                Milijunasi = string.Join(" i ", grupaMilijunasa.Select(k => k.ImePrezime)) 
            };

        foreach (var k in GrupirajPremaBanci)
        {
            Console.WriteLine($"{k.Banka}: {k.Milijunasi}");
        }

        Console.WriteLine();
        Console.WriteLine();

        var izvjestajMilijunasa = from milijunas in klijenti
            where milijunas.Stanje >= 1000000
            select milijunas;

        foreach (var k in izvjestajMilijunasa)
        {
            Console.WriteLine($"{k.ImePrezime} je u {banke.Find(b => b.Simbol == k.Banka).Naziv}");
        }

    }
}