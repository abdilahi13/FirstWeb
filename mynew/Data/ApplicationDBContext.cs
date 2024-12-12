using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using mynew.model;

namespace mynew.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
                
        }
        public DbSet<Category> Category {  get; set; }
    }
}
