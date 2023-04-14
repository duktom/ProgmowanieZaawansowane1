using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Knife
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Długość ostrza (cm)")]
        public double Lenghtcm { get; set; }

        [Display(Name = "Waga")]
        public double Weight { get; set; }

        [Display(Name = "Typ ostrza")]
        public string EdgeType { get; set; }

        [Display(Name = "Materiał rękojeści")]
        public string Material { get; set; }

        [Display(Name = "Stopień ostrości")]
        public double Sharpness { get; set; }

        
    }
}
