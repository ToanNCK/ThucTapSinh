using Microsoft.EntityFrameworkCore;

namespace WebApplication.Models.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TinMoiModel> TinMoi { get; set; }
    }
}
