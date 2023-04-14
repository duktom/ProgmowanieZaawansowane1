using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Vegetables
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Typ warzywa (np. pomidor, ogórek)")]
        public string VeggieType { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data siewu")]
        public DateTime PlantDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data zbioru")]
        public DateTime HarvestDate { get; set; }

        [Display(Name = "Waga")]
        public double Weight { get; set; }

        [Display(Name = "Cena")]
        public double Price { get; set; }

    }
}
