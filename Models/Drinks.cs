using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Drink
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Pojemność")]
        public double Capacity { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data przydatności do spożycia ")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "Typ (np. woda, sok, napój gazowany)")]
        public string DrinkType { get; set; }

        [Display(Name = "Smak (np. pomarańczowy, jabłkowy)")]
        public string Flavour { get; set; }

        [Display(Name = "Cena")]
        public double Price { get; set; }


    }
}
