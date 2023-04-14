using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Meat
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data przydatności do spożycia ")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Rodzaj (np. mielone, kawałki)")]
        public string MeatType { get; set; }

        [Display(Name = "Waga")]
        public double Weight { get; set; }

        [Display(Name = "Procentowa zawartość tłuszczu (%)")]
        public double FatPercetage { get; set; }

        [Display(Name = "Cena")]
        public double Price { get; set; }
    }
}
