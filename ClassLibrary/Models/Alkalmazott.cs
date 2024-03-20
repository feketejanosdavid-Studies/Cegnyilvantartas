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
    }
}
