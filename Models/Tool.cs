using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Tool
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Typ narzędzia (np. grabie, nożyce ogrodnicze)")]
        public string ToolType { get; set; }

        [Display(Name = "Materiał wykonania")]
        public string Material { get; set; }

        [Display(Name = "Waga")]
        public double Weight { get; set; }

        [Display(Name = "Długość (cm)")]
        public double Lenghtcm { get; set; }

        [Display(Name = "Cena")]
        public double Price { get; set; }
    }
}
