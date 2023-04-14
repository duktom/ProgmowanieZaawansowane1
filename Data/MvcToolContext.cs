using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcToolContext : DbContext
    {
        public MvcToolContext(DbContextOptions<MvcToolContext> options)
        : base(options)
        {
        }
        public DbSet<Tool> Tool { get; set; }
    }
}
