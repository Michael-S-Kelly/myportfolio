using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models;

namespace MyPortfolio.Data
{
    public class MyPortfolioUserDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public MyPortfolioUserDbContext(DbContextOptions<MyPortfolioUserDbContext> options) : base(options)
        {

        }
    }
}
