using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Pot
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Objentość")]
        public double Volume { get; set; }

        [Display(Name = "Waga")]
        public double Weight { get; set; }

        [Display(Name = "Typ pokrywki")]
        public string LidType { get; set; }
        
        [Display(Name = "Ilość uchwytów")]
        public int Handles { get; set; }

        [Display(Name = "Materiał wykonania")]
        public string Material { get; set; }
    }
}
