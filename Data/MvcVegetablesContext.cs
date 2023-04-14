using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcVegetablesContext : DbContext
    {
        public MvcVegetablesContext(DbContextOptions<MvcVegetablesContext> options)
        : base(options)
        {
        }
        public DbSet<Vegetables> Vegetables { get; set; }
    }
}
