using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Alcochol
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Objentość")]
        public double Volume { get; set; }
        
        [Display(Name = "Procentowa zawartość alkoholu (%)")]
        public double AlcVolume { get; set; }

        [Display(Name = "Ilość cukru (g/100 ml)")]
        public double SugarVolume { get; set; }
        
        [Display(Name = "Cena")]
        public double Price { get; set; }

        [Display(Name = "Rok Produkcji")]
        public int ProductonDate { get; set; }
    }
}
