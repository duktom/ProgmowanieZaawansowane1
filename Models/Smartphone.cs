using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Smartphone
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Pojemność pamięci (GB)")]
        public double Rom { get; set; }
        
        [Display(Name = "Liczba rdzeni procesora")]
        public int CoreNr { get; set; }

        [Display(Name = "Rozmiar ekranu")]
        public double DisplaySize { get; set; }

        [Display(Name = "Waga")]
        public double Weight { get; set; }

        [Display(Name = "Pojemność baterii (mAh)")]
        public double Battery { get; set; }


    }
}
