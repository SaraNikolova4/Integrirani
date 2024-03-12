using Lab1.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext <ConcertUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Lab1.Web.Models.Concert> Concert { get; set; } = default!;
        public DbSet<Lab1.Web.Models.Ticket> Ticket { get; set; } = default!;
    }
}
