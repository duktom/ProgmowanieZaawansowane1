using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Tree
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Wysokość")]
        public double Height { get; set; }

        [Display(Name = "Rodzaj (np. drzewo owocowe, iglaste)")]
        public string TreeType { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data posadzenia")]
        public DateTime PlantDate { get; set; }

        [Display(Name = "Średnica  Pnia (cm)")]
        public double Diameter { get; set; }

        [Display(Name = "Kolor liści ")]
        public string LeafColor { get; set; }

    }
}
