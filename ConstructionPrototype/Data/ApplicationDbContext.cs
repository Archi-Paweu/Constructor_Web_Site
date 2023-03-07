using ConstructionPrototype.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConstructionPrototype.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<JobOffer> JobOffers { get; set; }

        public DbSet<HomeArticle> HomeArticles { get; set; }

    }

}
