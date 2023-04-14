using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcPotContext : DbContext
    {
        public MvcPotContext(DbContextOptions<MvcPotContext> options)
        : base(options)
        {
        }
        public DbSet<Pot> Pot { get; set; }
    }
}
