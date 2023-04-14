using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcSmartphoneContext : DbContext
    {
        public MvcSmartphoneContext(DbContextOptions<MvcSmartphoneContext> options)
        : base(options)
        {
        }
        public DbSet<Smartphone> Smartphone { get; set; }
    }
}
