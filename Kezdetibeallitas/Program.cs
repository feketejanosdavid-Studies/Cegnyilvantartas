using ClassLibrary.Models;
using ClassLibrary.Data;
using System;



namespace Kezdetibeallitas
{
    public class Program
    {
        static void KiIr(IEnumerable<object> adatok)
        {
            foreach (var item in adatok)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }
    
        static void Main(string[] args)
        {
            CegContext db = new CegContext();

            if (!db.Alkalmazott.Any())
            {
                var sorok = File.ReadAllLines(@"c:\Users\Diak\..fjd\Második_félév\asztali_alkalmazasok\2024-03-20\alkalmazott.csv").Skip(1);
                foreach (var line in sorok)
                    db.Alkalmazott.Add(new Alkalmazott(line));
                db.SaveChanges();
            }

            KiIr(db.Alkalmazott);

            KiIr(db.Alkalmazott.Select(y => y.Nev));

            KiIr(db.Alkalmazott.Select(y => new {y.Nev, y.Fizetes}));

            KiIr(db.Alkalmazott.Select(y => new { y.Nev, Evesovedelem = y.Fizetes * 12 }).OrderByDescending(x=>x.Evesovedelem).Skip(1).Take(2));

            KiIr(db.Alkalmazott.Select(x => new { x.OsztalyId, x.Beosztas, x.FonokId }));

            KiIr(db.Alkalmazott.Select(x => new { x.Nev, x.Beosztas, x.Belepes }).OrderByDescending(x => x.Belepes));

            KiIr(db.Alkalmazott.Where(x => x.Nev.Equals("SKÓT")));

            KiIr(db.Alkalmazott.Where(x => x.Fizetes < 1200).OrderBy(x => x.Fizetes).Select(x => x.Nev));

            Console.WriteLine("Közepesen keresők száma:"+ db.Alkalmazott.Where(x => x.Fizetes > 1000 && x.Fizetes < 2000)+" db");
            KiIr(db.Alkalmazott.Where(x => x.Fizetes > 1000 && x.Fizetes < 2000));

            int[] t = { 7902, 7566, 7788 };
            KiIr(db.Alkalmazott.Where(x => t.Contains(x.FonokId)));
        }


    }
}