using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcAlcocholContext : DbContext
    {
        public MvcAlcocholContext(DbContextOptions<MvcAlcocholContext> options)
        : base(options)
        {
        }
        public DbSet<Alcochol> Alcochol { get; set; }
    }
}
