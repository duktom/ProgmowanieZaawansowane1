using AdvancedProgramming_Lesson1.Models;
using Microsoft.EntityFrameworkCore;

namespace AdvancedProgramming_Lesson1.Data
{
    public class MvcDiaryContext : DbContext
    {
        public MvcDiaryContext(DbContextOptions<MvcDiaryContext> options)
        : base(options)
        {
        }
        public DbSet<Diary> Diary { get; set; }
    }
}
