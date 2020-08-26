using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace AspNetCoreSQLSampleApplication.Data
{
    public class AspNetCoreSQLSampleApplicationContext : DbContext
    {
        public AspNetCoreSQLSampleApplicationContext (DbContextOptions<AspNetCoreSQLSampleApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
