using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson1.Models
{
    public class Book
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }

        [Display(Name = "Liczba stron")]
        public int PagesAmount { get; set; }

        [Display(Name = "Cena")]
        public double Price { get; set; }

        [Display(Name = "Rok Wydania")]
        public int ReleaseDate { get; set; }

        [Display(Name = "Ocena czytelników")]
        public double Rating { get; set; }

        [Display(Name = "Nakład ")]
        public int Overlay { get; set; }

    }
}
