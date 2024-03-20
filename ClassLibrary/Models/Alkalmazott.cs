using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Alkalmazott
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        [StringLength(40)]
        public string Nev { get; set; }
        public string Beosztas { get; set; }
        public int FonokId { get; set; }
        public DateTime Belepes { get; set; }
        public int Fizetes { get; set; }
        public int Jutalom { get; set; }
        public int OsztalyId { get; set; }

        public Alkalmazott() { 
         
        }

        public Alkalmazott(string sor)
        {
            string[] t = sor.Split(';');
            Id = Convert.ToInt32(t[0]);
            Nev = t[1];
            Beosztas = t[2];
            FonokId = t[3].Equals("") ? 0 : Convert.ToInt32(t[3]);
            Belepes = DateTime.Parse(t[4]);
            Fizetes = Convert.ToInt32(t[5]);
            Jutalom = t[6].Equals("") ? 0 : Convert.ToInt32(t[6]);
            OsztalyId = Convert.ToInt32(t[7]);
        }

        public override string? ToString()
        {
            return $"{Nev}, {Beosztas}, {Belepes}, {Fizetes}, {OsztalyId}";
        }
    }
}
