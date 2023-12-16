using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MvcApplication.Models;


namespace MvcApplication.data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<TGROUP> TGROUP { get; set; }
        public DbSet<TRELATION> TRELATION { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

    }
    
}

