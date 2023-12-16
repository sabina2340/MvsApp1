using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MvcApplication.Models;


namespace MvcApplication.data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TGROUP> Tgroup { get; set; }
        public DbSet<TRELATION> Trelation { get; set; }
        public DbSet<TGROUPRelation> TGROUPRelation { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Core_Entity;Username=postgres;Password=sabinamini04;");
        }

    }
    
}

