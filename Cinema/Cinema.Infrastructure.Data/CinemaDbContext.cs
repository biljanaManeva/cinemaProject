using Cinema.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Infrastructure.Data
{
    public class CinemaDbContext : DbContext
    {
        public CinemaDbContext(string cnnString) 
            : base(cnnString)
        {

        }
        public DbSet<Genre> Genres { get; set; } 
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Movie> CinemaHall { get; set; }
        public DbSet<Movie> User { get; set; }
    }
}
