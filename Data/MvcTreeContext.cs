using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcTreeContext : DbContext
    {
        public MvcTreeContext(DbContextOptions<MvcTreeContext> options)
        : base(options)
        {
        }
        public DbSet<Tree> Tree { get; set; }
    }
}
